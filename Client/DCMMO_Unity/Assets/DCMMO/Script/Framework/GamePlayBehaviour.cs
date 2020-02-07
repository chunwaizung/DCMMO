using UnityEngine;

namespace DC
{
    public class GamePlayBehaviour
    {
        public SysBox SysBoxP => SysBox.Instance;

    }

    public class MonoGamePlayBehaviour : BaseMonoBehaviour
    {
        public SysBox SysBoxP => SysBox.Instance;

    }
}