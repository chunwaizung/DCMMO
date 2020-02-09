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

            var idByidByte = GetIntBuf(id);

            var objBytes = t.ToByteArray();
            var contentBytes = new byte[4 + objBytes.Length];
            Array.Copy(idByidByte, 0, contentBytes, 0, 4);
            Array.Copy(objBytes, 4, contentBytes, 4, objBytes.Length);
            return contentBytes;
        }

        public static byte[] GetUshortBuf(ushort val)
        {
            var bytes = BitConverter.GetBytes(val);
            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return bytes;
        }

        public static byte[] GetIntBuf(int val)
        {
            var bytes = BitConverter.GetBytes(val);
            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return bytes;
        }

        public static ushort GetUshort(byte[] buf, int offset)
        {
            s_buf[0] = buf[offset];
            s_buf[1] = buf[offset + 1];

            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(s_buf, 0, 2);
            }
            return BitConverter.ToUInt16(s_buf, 0);
        }

        public static ushort GetUshort(byte[] buf)
        {
            return GetUshort(buf, 0);
        }

        private static readonly byte[] s_buf = new byte[4];
        public static int GetInt(byte[] buf, int offset)
        {
            s_buf[0] = buf[offset];
            s_buf[1] = buf[offset + 1];
            s_buf[2] = buf[offset + 2];
            s_buf[3] = buf[offset + 3];

            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(s_buf);
            }

            return BitConverter.ToInt32(s_buf, 0);
        }

        public static int GetInt(byte[] buf)
        {
            return GetInt(buf, 0);
        }

        public static ErrorCode CheckError(int id, ProtoPacket pkt)
        {
            if (pkt.ProtoObj is PErrorRes errorRes)
            {
                return (ErrorCode)errorRes.No;
            }

            return ErrorCode.UNIVERSAL;
        }
    }
}




