using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CullingScript : MonoBehaviour
{
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Level1Cull"))
        {
            Debug.Log("open part is set inactive");
            level1.SetActive(false);
        }

        if (other.CompareTag("Level2EndCull"))
        {
            Debug.Log("open part is set inactive");
            level2.SetActive(true);
        }

        if (other.CompareTag("Level2Cull"))
        {
            Debug.Log("Level 2 Culled");
            level2.SetActive(false);
        }
    }
}

