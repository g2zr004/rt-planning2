using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class laser_head : MonoBehaviour
{
    public Rigidbody rb;
    public float r = 20.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        if (mousePos.y >= 0){
            rb.transform.position = new Vector3(mousePos.x, Convert.ToSingle(Math.Sqrt(Math.Pow(r, 2) - Math.Pow(mousePos.x, 2) - Math.Pow(mousePos.z, 2))), mousePos.z);
        }
        else {
            rb.transform.position = new Vector3(mousePos.x, - Convert.ToSingle(Math.Sqrt(Math.Pow(r, 2) - Math.Pow(mousePos.x, 2) - Math.Pow(mousePos.z, 2))), mousePos.z);
        }
    }
}
