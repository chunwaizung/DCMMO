namespace DC
{
    public partial class GEvt
    {
        private const int start = GEvtCfg.sys_evt;

        /// <summary>
        /// 登录游戏服务器
        /// </summary>
        public const int connect_gsvr_suc = start + 1;
        
        /// <summary>
        /// 获取服务器列表
        /// </summary>
        public const int get_svr_list_suc = start + 2;



    }
}