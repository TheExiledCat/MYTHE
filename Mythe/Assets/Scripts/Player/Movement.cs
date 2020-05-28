using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Movements")]
    public float playerSpeed;
    public float jumpForce;

    Rigidbody snakehead;

    Vector3 x, z;

    void Start()
    {
        snakehead = GetComponent<Rigidbody>();

    }

    void Update()
    {
        //-----Inputs-----//
        x = transform.right * Input.GetAxisRaw("Horizontal");
        z = transform.forward * Input.GetAxisRaw("Vertical");

        //if (Input.GetKeyDown(KeyCode.Space))
        //    Jump();
    }

    void FixedUpdate()
    {
        Movements();
    }

    void Movements()
    {
        Vector3 movement = (x + z*1.1f) * playerSpeed;
        snakehead.AddForce(movement);
    }

    void Jump()
    {
        snakehead.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

}
