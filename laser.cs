using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour {

   public Rigidbody laser_head;
   public Rigidbody laser_end;
   public LineRenderer lr;
   public float lengthOfLineRenderer = 20.0f;
   public float laserWidth = 1.0f;
   public float laserLength = 50.0f;
   public Color color = Color.green;


   void Start() {
    lr = GetComponent<LineRenderer>();
    lr.startColor = color;
    lr.endColor = color;
    lr.startWidth = laserWidth;
    lr.endWidth = laserWidth;
    laser_head = laser_head.GetComponent<Rigidbody>();
    laser_end = laser_end.GetComponent<Rigidbody>();
   }

    void Update() {
        LineRenderer lr = GetComponent<LineRenderer>();
        lr.SetPosition(0, laser_head.transform.position);
        lr.SetPosition(1, laser_end.transform.position);
    }
}