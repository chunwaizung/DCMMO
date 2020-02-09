using Google.Protobuf;

namespace Dcgameprotobuf
{
    public static partial class DCGameProtocol
    {
        public static int GetId(IMessage t)
        {
            int id = 0;
            switch (t.GetType().Name)
            {
case "PRoleReq": id = 1010001;break;
case "PRoleRes": id = 1010002;break;
case "PLoginSvrReq": id = 1010003;break;
case "PLoginSvrRes": id = 1010004;break;
case "PAddRoleReq": id = 1010005;break;
case "PAddRoleRes": id = 1010006;break;
case "PDemoStrRes": id = 2000002;break;
case "PDemoStrReq": id = 2000001;break;
case "PErrorRes": id = 1000001;break;

            }

            return id;
        }

        public static object Parse(int proto_id, byte[] data, int offset, int length)
        {
            switch (proto_id)
            {
case 1010001: return PRoleReq.Descriptor.Parser.ParseFrom(data, offset, length);
case 1010002: return PRoleRes.Descriptor.Parser.ParseFrom(data, offset, length);
case 1010003: return PLoginSvrReq.Descriptor.Parser.ParseFrom(data, offset, length);
case 1010004: return PLoginSvrRes.Descriptor.Parser.ParseFrom(data, offset, length);
case 1010005: return PAddRoleReq.Descriptor.Parser.ParseFrom(data, offset, length);
case 1010006: return PAddRoleRes.Descriptor.Parser.ParseFrom(data, offset, length);
case 2000002: return PDemoStrRes.Descriptor.Parser.ParseFrom(data, offset, length);
case 2000001: return PDemoStrReq.Descriptor.Parser.ParseFrom(data, offset, length);
case 1000001: return PErrorRes.Descriptor.Parser.ParseFrom(data, offset, length);

            }

            return default;
        }
        
    }
}
