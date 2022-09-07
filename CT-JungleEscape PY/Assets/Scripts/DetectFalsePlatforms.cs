using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{


    void Update()
    {
        bool hit = Physics.Raycast(transform.position, transform.forward, 2, 1 << 8);

        if (hit)
        {
            hit = true;
            Debug.Log("All clear,go");
        }
        else
        {
            hit = false;
            Debug.LogWarning("Be careful man");
        }
    }
}
