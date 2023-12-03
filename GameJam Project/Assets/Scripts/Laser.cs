using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Laser : MonoBehaviour
{

    private Rigidbody rb;

    private Vector3 TargetPos;
    

    public enum Targets
    {
        ThePlayer, 
        Enemies,
        None
    }

    public Targets targets;

    private void Start() 
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update() 
    {
        switch (targets)
        {
            case Targets.ThePlayer:
                TargetPos = GameObject.FindWithTag("Player").transform.position;
                rb.MovePosition(TargetPos);
                rb.transform.LookAt(TargetPos);
                break;

            

        }
    }

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            Debug.Log("Hit");
            Destroy(gameObject);
        }
    }


}
