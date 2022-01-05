using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace e8e14766c6a82e2f2d10623bb56bd367
{

    public class TronAddress
    {
        /// <summary>
        /// Convert base58 tron address to hex format without 0x prefix
        /// </summary>
        /// <param name="address">Base58 tron address</param>
        /// <returns>ton address in hex representation without 0x prefix</returns>
        public static string FromBase58ToHex (string address)
        {
            var decodedBytes = Base58.Decode(address);

            return decodedBytes[0..^4]
                .ToHexString()
                .ToLower();
        }

        /// <summary>
        /// Convert tron address in bytes to base58 format
        /// </summary>
        /// <param name="address">tron address in bytes representation</param>
        /// <returns>tron address in base58 representation</returns>
        public static string FromBytesToBase58 (byte[] address)
        {
            var h2           = SHA256.HashData(SHA256.HashData(address));
            var addressBytes = address.Concat(h2.Take(4)).ToArray();

            return Base58.Encode(addressBytes); 
        }

        public static string FromBytesToBase58 (IEnumerable<byte> address) =>
            FromBytesToBase58(address.ToArray());
    }
}
