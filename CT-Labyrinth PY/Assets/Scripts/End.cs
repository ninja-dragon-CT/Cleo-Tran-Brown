using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class End : MonoBehaviour
{
    public Transform goal;
    private Transform key;
    private Transform end;
    private Animator animator;
    public NavMeshAgent agent;

    private void OnCollisionEnter(Collision collision)
    {
        //animator = GetComponentInChildren<Animator>();
        //agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
        agent.destination = key.position; 

        Destroy(this.gameObject);
    }
}
