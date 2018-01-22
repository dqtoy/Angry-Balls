using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryBallShooter : MonoBehaviour {

    // Use this for initialization
    public float thrust;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.F))
        {
            rb.AddForce(thrust, 0, 0, ForceMode.Impulse);
        }         
    }
}
