
using Nethereum.ABI;

using System.Collections.Generic;

namespace e8e14766c6a82e2f2d10623bb56bd367
{
    public static class ABIEncodeExtensions
    {
        public static byte[] Encode(this ABIEncode encode, string type, object value)
        {
            return encode.GetABIEncoded(new ABIValue(type, value));
        }

        public static byte[] Encode(this ABIEncode encode, params (string Type, object Value)[] abiItems)
        {
            var abiValues = new List<ABIValue>();

            foreach (var (Type, Value) in abiItems)
            {
                abiValues.Add(new ABIValue(Type, Value));
            }

            return encode.GetABIEncoded(abiValues.ToArray());
        }
    }
}
