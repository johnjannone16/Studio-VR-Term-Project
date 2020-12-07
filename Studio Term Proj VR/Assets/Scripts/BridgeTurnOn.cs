using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeTurnOn : MonoBehaviour
{
    public GameObject bridge;
   
    //public Renderer rend;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("BridgeOpen"))
        {
            Debug.Log("Animation Start");
            bridge.SetActive(true);
        }
    }
}
