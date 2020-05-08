using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempMovementScript : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        translation *= Time.deltaTime;

        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        rotation *= Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(translation, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, rotation, 0);

        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(translation, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotation, 0);
        }
    }

}
