using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("dkdkdkdkdkd");
        //OnCollisionEnter
    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("collide");
    //}
    void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("2d trigger");
    }
}
