namespace Dcgameprotobuf
{
    public static class DCProtocolIds
    {
public const int PErrorRes = 1000001;
public const int PSetPosNotify = 1020002;//设置actor位置
public const int PActorPlayerEnterViewNotify = 1020003;//player进入视野
public const int PActorLeaveViewNotify = 1020004;//actor离开视野，包括player、npc、pet
public const int PRoleEnterWorldNotify = 1020005;//创建玩家
public const int PActorPetEnterViewNotify = 1020006;//pet进入视野
public const int PActorNpcEnterViewNotify = 1020007;//npc进入视野
public const int PRoleReq = 1010001;//请求角色列表
public const int PRoleRes = 1010002;
public const int PLoginSvrReq = 1010003;//登录游戏服务器发送获得的roleId用来定位当前登录的角色
public const int PLoginSvrRes = 1010004;//登录成功
public const int PAddRoleReq = 1010005;//添加角色
public const int PAddRoleRes = 1010006;//添加角色
public const int PTestDemoClsReq = 2000003;
public const int PDemoStrRes = 2000002;
public const int PDemoStrReq = 2000001;
public const int PChangeLevelNotify = 1020001;//换关卡

    }
}
