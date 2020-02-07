namespace Dcgameprotobuf
{
    /*
     packet: len + protoId + reqBody
     */

    public partial struct ProtoPacket
    {
        public ushort len;
        public int protoId;
        public byte[] buf;

        /// <summary>
        /// 实际的proto内容的byte数据开始位置
        /// </summary>
        public int offset;
        public int protoLen;

        public static ProtoPacket CreateError(int id, int no, string msg)
        {
            return CreateError(id, no, TxtOp.TxtMsg, msg);
        }

        public static ProtoPacket CreateError(int id, int no, TxtOp op, string msg)
        {
            var packet = new ProtoPacket();
            packet.protoId = id;

            var errorRes = new ErrorRes();
            errorRes.No = no;
            errorRes.Msg = msg;
            errorRes.OpCode = op;

            packet.protoObj = errorRes;
            
            return packet;
        }

        public static ProtoPacket FromRecvBuf(byte[] buf)
        {
            return FromRecvBuf(buf, 0, buf.Length);
        }

        public static ProtoPacket FromRecvBuf(byte[] buf, int off, int len)
        {
            var packet = new ProtoPacket();
            packet.len = DCGameProtocol.GetUshort(buf, off);
            packet.protoId = DCGameProtocol.GetInt(buf, off + 2);
            packet.buf = buf;
            packet.offset = off + 2 + 4;
            //len = (protoIdBytesLength + protoContentBytesLength)
            packet.protoLen = len - 4;
            return packet;
        }

        object protoObj;

        public object ProtoObj
        {
            get
            {
                if (protoObj == null)
                {
                    protoObj = DCGameProtocol.Parse(protoId, buf, offset, protoLen);
                }
                return protoObj;
            }
        }

        public ErrorRes GetError()
        {
            return (ErrorRes) ProtoObj;
        }

    }

}
