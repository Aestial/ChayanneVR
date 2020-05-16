using UnityEngine;

public class ShootGrabbed : MonoBehaviour
{
    [SerializeField] Animator animator = default;
    [SerializeField] string animTriggerName = "Fire";
    [SerializeField] OVRInput.Button actionButton = default;    
    
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
            animator.SetTrigger(animTriggerName);
        }
    }
}
