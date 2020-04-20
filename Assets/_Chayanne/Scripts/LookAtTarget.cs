﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    [SerializeField] Transform target = default;

    void Update()
    {
        transform.LookAt(target);
    }
}
