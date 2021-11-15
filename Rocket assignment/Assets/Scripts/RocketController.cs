using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    Rigidbody rb;
    Vector3 jump = new Vector3(0, 1, 0);
    public float jumpForce;
    public float sidewaysForce;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, Input.GetAxis("Horizontal") * -sidewaysForce);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddRelativeForce(jump * jumpForce, ForceMode.Impulse);
        }

        
    }
}
