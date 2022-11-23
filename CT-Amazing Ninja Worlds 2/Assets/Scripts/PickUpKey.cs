using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{
    public ParticleSystem teleportDust;

    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        teleportDust.Play();
    }
}
