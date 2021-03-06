﻿using UnityEngine;

namespace DC.UI
{
    public class BaseItemUI<VGen> : BaseMonoBehaviour where VGen : MonoBehaviour
    {
        private VGen mVGen;

        public VGen ViewGen
        {
            get
            {
                if (null == mVGen)
                {
                    mVGen = GetComponent<VGen>();
                }

                if (null == mVGen)
                {
                    mVGen = gameObject.AddComponent<VGen>();
                }

                return mVGen;
            }
        }

        public object Param;
    }
}