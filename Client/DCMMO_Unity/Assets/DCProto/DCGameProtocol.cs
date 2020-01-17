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
case "ErrorRes": id = 1000001;break;
case "RoleRes": id = 1010002;break;

            }

            return id;
        }

        public static object Parse(int proto_id, byte[] data, int offset, int length)
        {
            switch (proto_id)
            {
case 1010001: return RoleReq.Descriptor.Parser.ParseFrom(data, offset, length);
case 1000001: return ErrorRes.Descriptor.Parser.ParseFrom(data, offset, length);
case 1010002: return RoleRes.Descriptor.Parser.ParseFrom(data, offset, length);

            }

            return default;
        }
        
    }
}
