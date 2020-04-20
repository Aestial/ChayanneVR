using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGrabbed : MonoBehaviour
{
    public OVRInput.Button actionButton;
    OVRGrabbable ovrGrabbable;
    Animator animator;      

    void Start()
    {        
        ovrGrabbable = GetComponent<OVRGrabbable>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (ovrGrabbable.isGrabbed &&
            OVRInput.GetDown(actionButton, ovrGrabbable.grabbedBy.GetController()))
        {
            animator.SetTrigger("Shoot");
        }
    }
}
