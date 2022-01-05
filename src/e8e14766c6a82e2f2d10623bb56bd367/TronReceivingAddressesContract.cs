using e8e14766c6a82e2f2d10623bb56bd367.Either;
using e8e14766c6a82e2f2d10623bb56bd367.Tron;
using e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages;

using Nethereum.ABI;
using Nethereum.Hex.HexConvertors.Extensions;
using Nethereum.Util;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e8e14766c6a82e2f2d10623bb56bd367
{

    public class TronReceivingAddressesContract
    {
        private readonly string ownerPrivateKey;
        private readonly string ownerAddress;
        private readonly string contractAddress;
        private readonly string contractBytecode;
        private readonly TronProtocol tronProtocol;

        public TronReceivingAddressesContract(
            string ownerPrivateKey,
            string ownerAddress,
            string contractAddress,
            string contractBytecode,
            TronProtocol tronProtocol)
        {
            this.ownerPrivateKey = ownerPrivateKey;
            this.ownerAddress = ownerAddress;
            this.contractAddress = contractAddress;
            this.contractBytecode = contractBytecode;
            this.tronProtocol = tronProtocol;
        }


        public async ValueTask<R<string>> AccumulateAsync(List<string> tokenAddresses, IEnumerable<string> salts)
        {
            var abi = new ABIEncode();

            var encodedSalts = salts.Select(x => abi.GetABIEncoded(new ABIValue("bytes32", x)));
            var encodedTokenAddresses = tokenAddresses.Select(base58 => TronAddress.FromBase58ToHex(base58)[2..]);

            var methodSelector = "accumulate(bytes32[],address[])";
            var methodArguments = abi
                .Encode(
                    ("bytes32[]", encodedSalts),
                    ("address[]", encodedTokenAddresses))
                .ToHexString();
            
            try
            {
                var response = await tronProtocol.SendAsync(new TriggerSmartContractRequest
                {
                    ContractAddress = contractAddress,
                    FromAddress = ownerAddress,
                    IsBase58Addresses = true,
                    MethodArguments = methodArguments,
                    MethodSelector = methodSelector,
                    FeeLimit = 1_000_000_000
                });

                var signing = TransactionSigner.Sign(
                    message: response.Transaction!.SummaryHex.HexToByteArray(),
                    key: ownerPrivateKey.HexToByteArray());

                var broadcast = await tronProtocol.SendAsync(new BroadcastTransactionRequest
                {
                    IsBase58Addresses = true,
                    Signature = new string[] { signing.Value.ToHexString() },
                    Summary = response.Transaction.Summary,
                    SummaryHex = response.Transaction.SummaryHex,
                    TxId = response.Transaction.TxId
                });

                var errorDuringBroadcast = !broadcast.IsBroadcasted;
                if (errorDuringBroadcast)
                {
                    return (
                        "26fcdf63-8b2f-464a-9315-703c8ec9cdbb",
                        $"error during broadcast: {broadcast.Error}, {broadcast.ErrorMessage}");
                }

                return response.Transaction!.TxId!;
            }
            catch (Exception exception)
            {
                return (
                    "ba3f09ab-97cf-49a4-b5b3-0597f9b975e9",
                    $"an error occurred during the request to collect the funds: {exception.Message}");
            }
        }

        public async Task<(string address, string salt)> RequestRandomAddressAsync ()
        {
            var sha3 = new Sha3Keccack();
            var abi  = new ABIEncode();
            
            var salt        = Guid.NewGuid().ToString().Replace("-", "");
            var encodedSalt = abi.Encode("bytes32", salt);

            var methodSelector  = "computeAddress(bytes32)";
            var methodArguments = abi
                .Encode("bytes32", encodedSalt)
                .ToHexString();

            var response = await tronProtocol.SendAsync(new TriggerConstantContractRequest
            {
                ContractAddress   = contractAddress,
                FromAddress       = ownerAddress,
                IsBase58Addresses = true,
                MethodArguments   = methodArguments,
                MethodSelector    = methodSelector
            });

            var addressBytes = new byte[] { 0x41 }.Concat(response.Constant.FirstOrDefault().HexToByteArray()[12..]).ToArray();
            var address = TronAddress.FromBytesToBase58(addressBytes);

            return (address, salt);
        }

        public (string Address, string Salt) IssueRandomAddress()
        {
            var sha3 = new Sha3Keccack();
            var abi = new ABIEncode();
            var bytecodeHash = sha3.CalculateHash(contractBytecode.HexToByteArray());

            var salt = Guid.NewGuid().ToString().Replace("-", "");
            var encodedSalt = abi.Encode("bytes32", salt);

            var ownerAddress = TronAddress
                .FromBase58ToHex(contractAddress)
                .HexToByteArray();

            var addressSource = ownerAddress.Concat(encodedSalt).Concat(bytecodeHash).ToArray();
            var addressBytes = new byte[] { 0x41 }.Concat(sha3.CalculateHash(addressSource)[12..]).ToArray();
            var address = TronAddress.FromBytesToBase58(addressBytes);

            return (address, salt);
        }
    }
}
