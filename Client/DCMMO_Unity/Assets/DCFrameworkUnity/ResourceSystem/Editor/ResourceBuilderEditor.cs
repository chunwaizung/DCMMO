using System.Collections;
using System.Collections.Generic;
using System.IO;
using DC.DCResourceSystem;
using UnityEngine;
using UnityEditor;

namespace DC
{
    public class ResourceBuilderEditor : Editor
    {
        private static ResourceBuilder sResourceBuilder = new ResourceBuilder();

        [MenuItem("DC/ResourceBuilder/Test")]
        public static void Test()
        {
            var asset1 = AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/DCMMO/Resources/test");//null
            var asset2 = AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/DCMMO/Resources/test.txt");//not null
            //asset bundle need extension

            DCLog.Log("end");
        }

        [MenuItem("DC/ResourceBuilder/BuildAssetExtension")]
        public static void BuildAssetExtensionMap()
        {
            var root = Application.dataPath + "/DCMMO/DCAssets/";
            var map = sResourceBuilder.BuildAssetExtensionMap(root);
            ResourceSys.SerializeExtMap(map, Path.Combine(Application.dataPath, "DCMMO/DCAssets/ext_map.bytes"));
            
            AssetDatabase.Refresh();
        }


        [MenuItem("DC/ResourceBuilder/BuildTest1")]
        public static void BuildTest1()
        {
            sResourceBuilder.BuildTest1(Path.Combine(Application.dataPath, "DCMMO/DCAssets"));
        }


    }

}
