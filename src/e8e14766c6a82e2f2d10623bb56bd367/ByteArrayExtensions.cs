using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace e8e14766c6a82e2f2d10623bb56bd367
{
    public static class ByteArrayExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToHexString(this byte[] array) => BitConverter.ToString(array).Replace("-", "");

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToUtf8String(this byte[] array) => Encoding.UTF8.GetString(array);
    }
}
