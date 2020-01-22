using System;
using System.IO;
using DC.DCResourceSystem;
using UnityEngine;

namespace DC
{
    public class ConfigUtil
    {
        public static byte[] GetBin(Type type)
        {
            return GetBin(type.Name);
        }

        public static byte[] GetBin(string binFileName)
        {
            var assetPath = "Assets/DCMMO/DCConfig/bin/" + binFileName + ".bytes";
            return ResourceSys.Instance.Load<TextAsset>(assetPath).bytes;
        }
    }
}