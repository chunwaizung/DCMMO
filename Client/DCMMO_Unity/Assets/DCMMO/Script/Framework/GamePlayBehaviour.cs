namespace DC
{
    public class GamePlayBehaviour : BaseMonoBehaviour
    {
        public ActorSys ActorSysP => SystemManager.Instance.GetSys<ActorSys>();

        public LevelSys LevelSysP => SystemManager.Instance.GetSys<LevelSys>();

        public virtual void Update()
        {

        }
    }
}