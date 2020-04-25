using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableRespawner : MonoBehaviour
{
    [SerializeField] float minfloorHeight;
    Transform original;

    void Start()
    {        
        original.position = transform.position;
        original.rotation = transform.rotation;
    }

    void Update()
    {
        if (transform.position.y < minfloorHeight)
        {
            Respawn();
        }
    }

    private void Respawn()
    {
        transform.position = original.position;
        transform.rotation = original.rotation;
    }
}
