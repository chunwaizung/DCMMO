using System;

namespace DC.Net
{
    public static class BytesHelper
    {
        public static byte[] GetBytes(ushort val)
        {
            if (BitConverter.IsLittleEndian)
            {
                return BitConverter.GetBytes(val);
            }
            else
            {
                return BitConverter.GetBytes(val).Swap();
            }
        }

        public static byte[] GetBytes(int val)
        {
            if (BitConverter.IsLittleEndian)
            {
                return BitConverter.GetBytes(val);
            }
            else
            {
                return BitConverter.GetBytes(val).Swap();
            }
        }

        public static ushort ToUInt16(byte[] value, int startIndex)
        {
            if (BitConverter.IsLittleEndian)
            {
                return BitConverter.ToUInt16(value, startIndex);
            }
            else
            {
                return BitConverter.ToUInt16(value.Swap(startIndex, sizeof(ushort)), startIndex);
            }
        }

        private static byte[] Swap(this byte[] vals, int startIdx, int len)
        {
            var dst = new byte[len];
            Buffer.BlockCopy(vals, startIdx, dst, 0, len);
            return Swap(dst);
        }

        private static byte[] Swap(this byte[] vals)
        {
            var count = vals.Length;
            for (int i = 0, j = count - 1; i < j; ++i, --j)
            {
                var temp = vals[i];
                vals[i] = vals[j];
                vals[j] = temp;
            }

            return vals;
        }
    }
}