using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class End : MonoBehaviour
{
    public Transform goal;
    private Transform end;
    public NavMeshAgent CubeMan;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //animator = GetComponentInChildren<Animator>();
            //agent = GetComponent<NavMeshAgent>();
            CubeMan.destination = goal.position;

            GameObject.Find("Main Camera").GetComponent<CamFollow>().player = CubeMan.gameObject;

            Destroy(this.gameObject);

        }
    }
}
