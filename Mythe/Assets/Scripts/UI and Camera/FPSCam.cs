﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCam : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject pausemenuUI;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3((Input.GetAxis("Mouse Y") * -1), 0));
        if (pausemenuUI.activeSelf == true)
            Cursor.lockState = CursorLockMode.None;
        else
            Cursor.lockState = CursorLockMode.Locked;


    }
}