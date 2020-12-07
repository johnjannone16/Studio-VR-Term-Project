using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeOff : MonoBehaviour
{
    public GameObject bridge;
    
    
    private void OnTriggerEnter(Collider other)
    {
        bridge.SetActive(false);
    }
}
