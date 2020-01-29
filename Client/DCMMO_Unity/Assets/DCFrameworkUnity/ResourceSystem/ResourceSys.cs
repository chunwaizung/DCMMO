﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace DC.DCResourceSystem
{

    public class ResourceSys : Singleton<ResourceSys>
    {
        private Dictionary<string, string> mPathToExt;

        protected override void OnInit()
        {
            mPathToExt = DeserializeMap(Load<TextAsset>("Assets/DCMMO/DCAssets/ext_map.bytes").bytes);
        }

        public string GetPathWithExt(string path)
        {
            if (mPathToExt.TryGetValue(path, out var newPath))
            {
                return newPath;
            }
            return path;
        }

        public T Load<T>(string path) where T : Object
        {
            var pathWithExt = GetPathWithExt(path);

#if UNITY_EDITOR
            return AssetDatabase.LoadAssetAtPath<T>(pathWithExt);
#endif
            return Resources.Load<T>(path);
        }

        public Object[] LoadAll(string path)
        {
            var pathWithExt = GetPathWithExt(path);

#if UNITY_EDITOR
            return AssetDatabase.LoadAllAssetsAtPath(pathWithExt);
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
        public static void SerializeExtMap(Dictionary<string, string> map, string path)
        {
            using (var writer = new StreamWriter(File.OpenWrite(path)))
            {
                foreach (var kv in map)
                {
                    writer.WriteLine(kv.Key);
                    writer.WriteLine(kv.Value);
                }
            }
        }

        public static Dictionary<string, string> DeserializeMap(byte[] content)
        {
            var dic = new Dictionary<string, string>();
            using (var reader = new StreamReader(new MemoryStream(content)))
            {
                string key = null;
                var readLine = reader.ReadLine();
                while (!string.IsNullOrEmpty(readLine))
                {
                    if (key == null)
                    {
                        key = readLine;
                        continue;
                    }

                    dic.Add(key, readLine);
                    key = null;
                }
            }

            return dic;
        }
    }
}
