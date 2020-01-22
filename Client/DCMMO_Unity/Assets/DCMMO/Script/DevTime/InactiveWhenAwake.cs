﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DC
{
    public class InactiveWhenAwake : MonoBehaviour
    {
        void Awake()
        {
            gameObject.SetActive(false);
        }
    }
}