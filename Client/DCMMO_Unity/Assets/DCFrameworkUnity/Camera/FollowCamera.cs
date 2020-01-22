using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DC
{
    public class FollowCamera : BaseMonoBehaviour
    {

        public Transform mFollowTf;

        public bool mAutoRelative;

        public Vector3 mOffset;

        public Quaternion mRotation;
        

        // Start is called before the first frame update
        void Start()
        {
            if (mAutoRelative)
            {
                UpdateOffset();
            }
        }

        public void SetFollowTf(Transform followTf)
        {
            mFollowTf = followTf;
            UpdateOffset();
        }

        public void UpdateOffset()
        {
            mOffset = CacheTransform.position - mFollowTf.position;
        }

        // Update is called once per frame
        void Update()
        {
            if(mFollowTf == null) return;

            CacheTransform.position = mFollowTf.position + mOffset;
        }
    }

}
