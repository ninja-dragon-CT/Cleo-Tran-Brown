using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{
    public ParticleSystem Pickup;

    void Start()
    {
        Pickup.Stop();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Door"));

            Destroy(other.gameObject);

            Pickup.Play();
        }

    }


}
