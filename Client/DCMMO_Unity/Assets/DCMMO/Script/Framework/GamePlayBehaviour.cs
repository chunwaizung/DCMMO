namespace DC
{
    /// <summary>
    /// 尽量不要直接使用
    /// </summary>
    public class SysBox
    {
        public static readonly SysBox Instance = new SysBox();

        public GameMain GameMainP => GameMain.Instance;

        public UnityMsgDispatcher UnityMsgDis => GameMainP.UnityMsgDispatcher;

        public NetworkService NetworkServiceP => SystemManager.Instance.GetSys<NetworkService>();

        public ActorSys ActorSysP => SystemManager.Instance.GetSys<ActorSys>();

        public LevelSys LevelSysP => SystemManager.Instance.GetSys<LevelSys>();

        public UISys UiSysP => SystemManager.Instance.GetSys<UISys>();

        public DCLocalServer LocalServerP => SystemManager.Instance.GetSys<DCLocalServer>();

    }

    public class GamePlayBehaviour : BaseMonoBehaviour
    {
        public SysBox SysBoxP => SysBox.Instance;

    }
}