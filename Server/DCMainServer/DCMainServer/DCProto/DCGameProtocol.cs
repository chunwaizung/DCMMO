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
case "ErrorRes": id = 1000001;break;
case "RoleRes": id = 1010002;break;
case "LoginSvrReq": id = 1010003;break;
case "DemoStrRes": id = 2000002;break;
case "DemoStrReq": id = 2000001;break;
case "RoleReq": id = 1010001;break;

            }

            return id;
        }

        public static object Parse(int proto_id, byte[] data, int offset, int length)
        {
            switch (proto_id)
            {
case 1000001: return ErrorRes.Descriptor.Parser.ParseFrom(data, offset, length);
case 1010002: return RoleRes.Descriptor.Parser.ParseFrom(data, offset, length);
case 1010003: return LoginSvrReq.Descriptor.Parser.ParseFrom(data, offset, length);
case 2000002: return DemoStrRes.Descriptor.Parser.ParseFrom(data, offset, length);
case 2000001: return DemoStrReq.Descriptor.Parser.ParseFrom(data, offset, length);
case 1010001: return RoleReq.Descriptor.Parser.ParseFrom(data, offset, length);

            }

            return default;
        }
        
    }
}
