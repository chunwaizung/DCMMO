using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace DC
{
    public class ResourceBuilderEditor : Editor
    {
        [MenuItem("DC/ResourceBuilder/Test")]
        public static void Test()
        {
            var asset1 = AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/DCMMO/Resources/test");//null
            var asset2 = AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/DCMMO/Resources/test.txt");//not null
            //asset bundle need extension

            DCLog.Log("end");
        }
    }
}