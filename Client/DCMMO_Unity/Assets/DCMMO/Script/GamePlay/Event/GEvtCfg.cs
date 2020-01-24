namespace DC
{
    public class GEvtCfg
    {
        public const int evt_delta = 10000;

        public const int sys_evt = 1000000;

        public const int actor_evt = sys_evt + evt_delta * 1;

        public const int map_evt = sys_evt + evt_delta * 2;

        public const int user_evt = sys_evt + evt_delta * 3;

    }
}