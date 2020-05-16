using System.Collections;
using UnityEngine;

public class GrabbableRespawner : MonoBehaviour
{
    [SerializeField] float minfloorHeight = 0.0f;
    [SerializeField] float waitTime = 3.0f;
    Vector3 originalPos = new Vector3();
    Quaternion originalRot = new Quaternion();
    new Rigidbody rigidbody;
    bool inFloor;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        originalPos = transform.position;
        originalRot = transform.rotation;
    }

    void Update()
    {
        if (transform.position.y < minfloorHeight)
        {
            if (!inFloor)
                WaitAndRespawn(waitTime);
            inFloor = true;
        }
    }

    void WaitAndRespawn(float seconds)
    {
        StartCoroutine(WaitAndRespawnCoroutine(seconds));
    }

    void Respawn()
    {        
        transform.position = originalPos;
        transform.rotation = originalRot;
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
        inFloor = false;
    }

    IEnumerator WaitAndRespawnCoroutine(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Respawn();
    }

}
