﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody rigidbody;

    float jumpForce = 5.7f;

    public bool isGrounded;

    float falMultiplier = 1.5f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, .15f);
        Debug.DrawRay(transform.position, Vector3.down * .15f, new Color(0.6f, 1, 0.6f));

        if(Input.GetButtonDown("Jump") && isGrounded){
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if(rigidbody.velocity.y < 0)
        {
            rigidbody.velocity += Physics.gravity * falMultiplier * Time.deltaTime;
        }
    }
}

