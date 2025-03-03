using UnityEngine;

public class AirPlane : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float enginePower = 20f;
    [SerializeField] float liftBooster = 0.5f;
    [SerializeField] float drag = 0.01f;
    [SerializeField] float angularDrag = 0.01f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.forward * enginePower);
        }
    }
}
