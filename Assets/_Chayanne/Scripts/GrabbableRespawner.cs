using UnityEngine;

public class GrabbableRespawner : MonoBehaviour
{
    [SerializeField] float minfloorHeight = 0.0f;
    Vector3 originalPos = new Vector3();
    Quaternion originalRot = new Quaternion();
    new Rigidbody rigidbody;

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
            Respawn();
        }
    }

    private void Respawn()
    {
        transform.position = originalPos;
        transform.rotation = originalRot;
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
    }
}
