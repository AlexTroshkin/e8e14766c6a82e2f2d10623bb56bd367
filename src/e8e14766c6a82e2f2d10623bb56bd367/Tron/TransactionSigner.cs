using e8e14766c6a82e2f2d10623bb56bd367.Either;

using System.Linq;
using System.Security.Cryptography;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron
{
    public class TransactionSigner
    {
        public const string E_ACCOUNT_RECEIVING = "70d0b2d8-075e-431e-b2ea-027b968d5401";
        public const string E_TRANSACTION_PROCESSING = "20e76cf9-3772-46ea-a1df-436e0b461b9f";
        public const string E_TRANSACTION_BROADCAST = "560cd035-cf7f-4626-87ad-968c7cda0415";

        public const string E_PRIVATE_KEY_VERIFICATION = "366b27e5-c279-47f0-9a87-73d75b4627b5";
        public const string E_SIGNING = "a3e62eff-4dc3-4854-b8ac-7e3a593ba4f3";

        public static R<byte[]> Sign(byte[] message, byte[] key)
        {
            var privateKeyNotCreated = !NBitcoin.Secp256k1.ECPrivKey.TryCreate(key, out var privateKey);
            if (privateKeyNotCreated) return (E_PRIVATE_KEY_VERIFICATION,
                "An error occured while creating a private key");

            var messageHash = SHA256.HashData(message);
            var recoverableSignatureNotCreated = !privateKey!.TrySignRecoverable(messageHash, out var recoverableSignature);
            if (recoverableSignatureNotCreated) return (E_SIGNING,
                "An error occurred while creating a recoverable signature");

            recoverableSignature!.Deconstruct(out var r, out var s, out var recid);

            var rBytes = r.ToBytes();
            var sBytes = s.ToBytes();
            var recBytes = new byte[] { (byte)(recid + 27) };

            return rBytes
                .Concat(sBytes)
                .Concat(recBytes)
                .ToArray();
        }
    }
}
