namespace Dcgameprotobuf
{
    public static class DCProtocolIds
    {
public const int RoleReq = 1010001;//请求角色列表
public const int RoleRes = 1010002;
public const int LoginSvrReq = 1010003;//登录游戏服务器发送获得的roleToken用来定位当前登录的角色
public const int LoginSvrRes = 1010004;//登录成功
public const int AddRoleReq = 1010005;//添加角色
public const int AddRoleRes = 1010006;//添加角色
public const int DemoStrRes = 2000002;
public const int DemoStrReq = 2000001;
public const int ErrorRes = 1000001;

    }
}
