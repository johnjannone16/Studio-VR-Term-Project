using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeOpener : MonoBehaviour
{
    public GameObject bridge;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("AnimationStarter"))
        {
            Debug.Log("Bridge Open");
            bridge.SetActive(true);
        }
    }
}
