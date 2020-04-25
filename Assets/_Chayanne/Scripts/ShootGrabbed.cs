using UnityEngine;

public class ShootGrabbed : MonoBehaviour
{
    [SerializeField] OVRInput.Button actionButton = default;
    [SerializeField] Animator animator = default;
    OVRGrabbable ovrGrabbable;   

    void Start()
    {        
        ovrGrabbable = GetComponent<OVRGrabbable>();        
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
