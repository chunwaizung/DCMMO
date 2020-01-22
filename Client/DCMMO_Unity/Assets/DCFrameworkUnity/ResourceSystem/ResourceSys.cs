using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace DC.DCResourceSystem
{

    public class ResourceSys : Singleton<ResourceSys>
    {
        public T Load<T>(string path) where T : Object
        {
#if UNITY_EDITOR
            return AssetDatabase.LoadAssetAtPath<T>(path);
#endif
            return Resources.Load<T>(path);
        }

        public Object[] LoadAll(string path)
        {
#if UNITY_EDITOR
            return AssetDatabase.LoadAllAssetsAtPath(path);
#endif
            return Resources.LoadAll(path);
        }

        public Sprite GetSprite(string icon)
        {
            return Resources.Load<Sprite>(icon);
        }

        public bool SetImage(Image img, string icon)
        {
            var sprite = GetSprite(icon);
            img.sprite = sprite;
            return sprite != null;
        }
    }
}
