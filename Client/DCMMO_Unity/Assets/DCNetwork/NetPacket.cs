using System.IO;

namespace DC.Net
{
    public class NetPacket
    {
        public byte[] buf;
    }

    public enum ReadState
    {
        Length,
        Body,
    }

    public class ByteBuf
    {
        
        //10mb cache
        private byte[] mBuf = new byte[1024 * 1024 * 10];

        public int Write(byte[] buf, int offset, int len)
        {
            return 0;
        }

        public int Read(byte[] buf, int offset, int len)
        {
            return 0;
        }

        public int Write(Stream stream)
        {
            var cnt = 0;
            return cnt;
        }

    }

    public class BufReader
    {
        private ReadState mReadState = ReadState.Length;

        private ByteBuf mByteBuf;

        public byte[] ReadPack()
        {
            return null;
        }
    }
}