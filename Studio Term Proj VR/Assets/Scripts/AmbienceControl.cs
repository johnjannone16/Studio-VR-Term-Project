using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbienceControl : MonoBehaviour
{
    public AudioSource inside;
    public AudioSource outside;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            outside.enabled = false;
            inside.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        outside.enabled = true;
        inside.enabled = false;
    }
}
