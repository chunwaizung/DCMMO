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
case "PErrorRes": id = 1000001;break;
case "PSetPosNotify": id = 1020002;break;
case "PActorPlayerEnterViewNotify": id = 1020003;break;
case "PActorLeaveViewNotify": id = 1020004;break;
case "PRoleEnterWorldNotify": id = 1020005;break;
case "PActorPetEnterViewNotify": id = 1020006;break;
case "PActorNpcEnterViewNotify": id = 1020007;break;
case "PRoleReq": id = 1010001;break;
case "PRoleRes": id = 1010002;break;
case "PLoginSvrReq": id = 1010003;break;
case "PLoginSvrRes": id = 1010004;break;
case "PAddRoleReq": id = 1010005;break;
case "PAddRoleRes": id = 1010006;break;
case "PTestDemoClsReq": id = 2000003;break;
case "PDemoStrRes": id = 2000002;break;
case "PDemoStrReq": id = 2000001;break;
case "PChangeLevelNotify": id = 1020001;break;

            }

            return id;
        }

        public static object Parse(int proto_id, byte[] data, int offset, int length)
        {
            switch (proto_id)
            {
case 1000001: return PErrorRes.Descriptor.Parser.ParseFrom(data, offset, length);
case 1020002: return PSetPosNotify.Descriptor.Parser.ParseFrom(data, offset, length);
case 1020003: return PActorPlayerEnterViewNotify.Descriptor.Parser.ParseFrom(data, offset, length);
case 1020004: return PActorLeaveViewNotify.Descriptor.Parser.ParseFrom(data, offset, length);
case 1020005: return PRoleEnterWorldNotify.Descriptor.Parser.ParseFrom(data, offset, length);
case 1020006: return PActorPetEnterViewNotify.Descriptor.Parser.ParseFrom(data, offset, length);
case 1020007: return PActorNpcEnterViewNotify.Descriptor.Parser.ParseFrom(data, offset, length);
case 1010001: return PRoleReq.Descriptor.Parser.ParseFrom(data, offset, length);
case 1010002: return PRoleRes.Descriptor.Parser.ParseFrom(data, offset, length);
case 1010003: return PLoginSvrReq.Descriptor.Parser.ParseFrom(data, offset, length);
case 1010004: return PLoginSvrRes.Descriptor.Parser.ParseFrom(data, offset, length);
case 1010005: return PAddRoleReq.Descriptor.Parser.ParseFrom(data, offset, length);
case 1010006: return PAddRoleRes.Descriptor.Parser.ParseFrom(data, offset, length);
case 2000003: return PTestDemoClsReq.Descriptor.Parser.ParseFrom(data, offset, length);
case 2000002: return PDemoStrRes.Descriptor.Parser.ParseFrom(data, offset, length);
case 2000001: return PDemoStrReq.Descriptor.Parser.ParseFrom(data, offset, length);
case 1020001: return PChangeLevelNotify.Descriptor.Parser.ParseFrom(data, offset, length);

            }

            return default;
        }
        
    }
}
