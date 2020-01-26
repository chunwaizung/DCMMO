﻿namespace Dcgameprotobuf
{
    /*
     packet: len + protoId + reqBody
     */

    public partial struct ProtoPacket
    {
        public ushort len;
        public int protoId;
        public byte[] buf;

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

            packet.res = errorRes;
            
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
            packet.protoLen = len - packet.offset;
            return packet;
        }

        object res;

        public object Res
        {
            get
            {
                if (res == null)
                {
                    res = DCGameProtocol.Parse(protoId, buf, offset, protoLen);
                }
                return res;
            }
        }

    }

}