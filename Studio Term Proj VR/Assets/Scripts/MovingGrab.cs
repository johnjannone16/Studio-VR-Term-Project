using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class MovingGrab : MonoBehaviour
{
    public GameObject Parent2Be;
    public GameObject Child2Transfer;   
    private bool grabable;


    // Start is called before the first frame update
    void Start()
    {
        grabable = false;       
       
    }


    private void OnTriggerEnter(Collider other)
    {
        grabable = true;
    }

    private void OnTriggerExit(Collider other)
    {
        grabable = false;
    }
    public void SetParent(GameObject newParent)
    {
        Child2Transfer.transform.parent = newParent.transform;
        Debug.Log("Child2Transfer's Parent: " + Child2Transfer.transform.parent.name);

        if (newParent.transform.parent != null)
        {
            Debug.Log("Child2Transfer's ground parent: " + Child2Transfer.transform.parent.parent.name);
        }
    }

  

    public void DetachFrom()
    {
        if(grabable == true)
            Child2Transfer.transform.parent = null;
    }

    public void TransferChildObject()
    {
        if(grabable == true)
            Child2Transfer.transform.localPosition = Parent2Be.transform.localPosition;
    
    }
}
