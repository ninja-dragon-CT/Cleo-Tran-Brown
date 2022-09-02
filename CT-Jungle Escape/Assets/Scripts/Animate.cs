using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    Animator Animator;

    Jump Jump;

    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
        Jump = GetComponent<Jump>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Jump.isGrounded){
            //play jump animation
        }

        if (Jump.isGrounded) { 
        
            //play idle animation
            if (Input.GetAxisRaw("Vertical") == 1)
            {
                
            }
            //play idle animation
            if (Input.GetAxisRaw("Vertical") == -1)
            {

            }

        }
    }
}
