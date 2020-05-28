using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum : MonoBehaviour
{

    public Rigidbody body;
    public float timeLeft = 2f;
    public float resetTime = 2f;
    public bool turned = false;

    void Start()
    {
        var hinge = GetComponent<HingeJoint>();

        var motor = hinge.motor;
        motor.force = 100;
        motor.targetVelocity = 200;
        hinge.motor = motor;
        hinge.useMotor = true;

    }

    void Update()
    {
        var hinge = GetComponent<HingeJoint>();

        var motor = hinge.motor;
        timeLeft -= Time.deltaTime;
        if(timeLeft < 0)
        {
            if (turned == true)
            {
                motor.targetVelocity = 200;
                turned = false;
            }
            else if (turned == false)
            {
                motor.targetVelocity = -200;
                turned = true;
            }
            
            timeLeft = resetTime;
        }
        hinge.motor = motor;
        hinge.useMotor = true;
    }

}
