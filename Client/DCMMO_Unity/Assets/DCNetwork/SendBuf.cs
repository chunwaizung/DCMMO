namespace DC.Net
{
    public struct SendBuf
    {
        public int off;
        public int len;
        public byte[] buf;

        public static SendBuf From(byte[] buf)
        {
            return From(buf, 0, buf.Length);
        }

        public static SendBuf From(byte[] buf, int off, int len)
        {
            var sendBuf = new SendBuf();

            sendBuf.off = off;
            sendBuf.len = len;
            sendBuf.buf = buf;

            return sendBuf;
        }
    }
}