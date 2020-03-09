namespace DC
{
    public class GameBehaviourSingleton<T> : Singleton<T> where T : GameBehaviourSingleton<T>, new()
    {
        public SysBox SysBoxP => SysBox.Instance;
    }
}