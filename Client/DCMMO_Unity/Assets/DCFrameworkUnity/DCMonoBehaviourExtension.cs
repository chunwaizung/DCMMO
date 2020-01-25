using UnityEngine;

namespace DC
{
    public static class DCMonoBehaviourExtension
    {
        public static bool TryGetComponent<T>(this MonoBehaviour mono, out T t) where T : Component
        {
            t = mono.GetComponent<T>();
            return t != null;
        }
    }
}