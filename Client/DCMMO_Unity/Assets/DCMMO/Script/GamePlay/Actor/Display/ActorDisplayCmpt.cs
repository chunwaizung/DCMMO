namespace DC
{
    public class ActorDisplayCmpt : BaseActorCmpt
    {

        private ActorModelMgr mModelMgr;

        private ActorEffectMgr mEfxMgr;

        public ActorModelMgr GetModelMgr()
        {
            return mModelMgr;
        }

        public ActorEffectMgr GetActorEffectMgr()
        {
            return mEfxMgr;
        }


    }
}