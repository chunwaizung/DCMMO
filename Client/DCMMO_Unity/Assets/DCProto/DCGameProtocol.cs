using Google.Protobuf;

namespace Dcgameprotobuf
{
    public static partial class DCGameProtocol
    {
        public static int GetId<T>(T t) where T : IMessage<T>
        {
            int id = 0;
            switch (typeof(T).Name)
            {
case "RoleReq": id = 1010001;break;
case "ErrorRes": id = 1000001;break;
case "RoleRes": id = 1010002;break;

            }

            return id;
        }

        public static object Parse(byte[] data, out int id)
        {
            var proto_id = GetProtoId(data);
            id = proto_id;
            var offset = 4;
            var length = data.Length - offset;

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
