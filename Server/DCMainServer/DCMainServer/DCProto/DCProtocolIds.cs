namespace Dcgameprotobuf
{
    public static class DCProtocolIds
    {
public const int PRoleReq = 1010001;//请求角色列表
public const int PRoleRes = 1010002;
public const int PLoginSvrReq = 1010003;//登录游戏服务器发送获得的roleId用来定位当前登录的角色
public const int PLoginSvrRes = 1010004;//登录成功
public const int PAddRoleReq = 1010005;//添加角色
public const int PAddRoleRes = 1010006;//添加角色
public const int PDemoStrRes = 2000002;
public const int PDemoStrReq = 2000001;
public const int PErrorRes = 1000001;

    }
}
