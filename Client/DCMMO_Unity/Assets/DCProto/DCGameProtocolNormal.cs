using System;
using Google.Protobuf;

namespace Dcgameprotobuf
{
    public static partial class DCGameProtocol
    {
        public static byte[] Convert<T>(int id, T t) where T : IMessage<T>
        {
            if (id == 0)
            {
                //todo log error
                return new byte[1] { 0 };
            }

            byte[] idByidByte = BitConverter.GetBytes(id);
            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(idByidByte);
            }

            var objBytes = t.ToByteArray();
            var contentBytes = new byte[4 + objBytes.Length];
            Array.Copy(idByidByte, 0, contentBytes, 0, 4);
            Array.Copy(objBytes, 4, contentBytes, 4, objBytes.Length);
            return contentBytes;
        }

        private static readonly byte[] s_no = new byte[4];

        public static int GetProtoId(byte[] content)
        {
            s_no[0] = content[0];
            s_no[1] = content[1];
            s_no[2] = content[2];
            s_no[3] = content[3];

            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(s_no);
            }

            BitConverter.ToInt32(s_no, 0);
            return 0;
        }

        public static T Parse<T>(byte[] data) where T : IMessage<T>
        {
            var o = Parse(data);
            if (o != null)
            {
                return (T)o;
            }

            return default;
        }
    }
}