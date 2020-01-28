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
case "RoleReq": id = 1010001;break;
case "RoleRes": id = 1010002;break;
case "LoginSvrReq": id = 1010003;break;
case "LoginSvrRes": id = 1010004;break;
case "AddRoleReq": id = 1010005;break;
case "AddRoleRes": id = 1010006;break;
case "DemoStrRes": id = 2000002;break;
case "DemoStrReq": id = 2000001;break;
case "ErrorRes": id = 1000001;break;

            }

            return id;
        }

        public static object Parse(int proto_id, byte[] data, int offset, int length)
        {
            switch (proto_id)
            {
case 1010001: return RoleReq.Descriptor.Parser.ParseFrom(data, offset, length);
case 1010002: return RoleRes.Descriptor.Parser.ParseFrom(data, offset, length);
case 1010003: return LoginSvrReq.Descriptor.Parser.ParseFrom(data, offset, length);
case 1010004: return LoginSvrRes.Descriptor.Parser.ParseFrom(data, offset, length);
case 1010005: return AddRoleReq.Descriptor.Parser.ParseFrom(data, offset, length);
case 1010006: return AddRoleRes.Descriptor.Parser.ParseFrom(data, offset, length);
case 2000002: return DemoStrRes.Descriptor.Parser.ParseFrom(data, offset, length);
case 2000001: return DemoStrReq.Descriptor.Parser.ParseFrom(data, offset, length);
case 1000001: return ErrorRes.Descriptor.Parser.ParseFrom(data, offset, length);

            }

            return default;
        }
        
    }
}
