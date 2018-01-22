using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;

    // Use this for initialization
    void Start()
    {
        //camera1.enabled = !camera1.enabled;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("1"))
        {
            camera1.enabled = true;
            camera2.enabled = false;
        }


        if (Input.GetKeyDown("2"))
        {
            camera1.enabled = false;
            camera2.enabled = true;
        }
    }
}
