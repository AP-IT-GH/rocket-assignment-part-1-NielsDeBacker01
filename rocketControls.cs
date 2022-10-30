using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketControls : MonoBehaviour
{
    Rigidbody rb;
    public float throttle;
    public float spin;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.constraints = RigidbodyConstraints.None;
        if (Input.GetKey(KeyCode.Space)){
            rb.AddRelativeForce(new Vector3(0,throttle,0), ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.LeftArrow)){
            rb.AddTorque(new Vector3(0,0,spin), ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.RightArrow)){
            rb.AddTorque(new Vector3(0,0,-1 * spin), ForceMode.Impulse);
        }
        rb.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotation;
    }
}
