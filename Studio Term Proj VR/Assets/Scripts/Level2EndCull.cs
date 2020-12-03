using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2EndCull : MonoBehaviour
{
    public GameObject level2;
    private void OnTriggerEnter(Collider other)
    {
        
            Debug.Log("open part is set inactive");
            level2.SetActive(true);
        
    }
}
