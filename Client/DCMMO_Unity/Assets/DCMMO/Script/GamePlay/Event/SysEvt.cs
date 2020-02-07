namespace DC
{
    public class SysEvt
    {
        private const int sys_evt_start = GEvtCfg.sys_evt;

        /// <summary>
        /// 登录游戏服务器
        /// </summary>
        public const int connect_gsvr_suc = sys_evt_start + 1;
        
        /// <summary>
        /// 获取服务器列表
        /// </summary>
        public const int get_svr_list_suc = sys_evt_start + 2;



    }
}