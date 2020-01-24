using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DC
{
    public class ResourceSysTest : MonoBehaviour
    {
        void Start()
        {
            var asset1 = Resources.Load<TextAsset>("test");//not null
            var asset2 = Resources.Load<TextAsset>("test.txt");//null
            DCLog.Log("end");

//            Resources.Load<Texture2D>("");
        }
    }
}