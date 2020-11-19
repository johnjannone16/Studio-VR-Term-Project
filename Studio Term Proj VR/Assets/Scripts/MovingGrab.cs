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
    public static bool grab;
    Renderer rend;
    public int gripCounter;
    public GameObject FalseParent;
    private Climber climber;
    public CharacterController character;
    public ContinuousMovement continuousMovement;

    // Start is called before the first frame update
    void Start()
    {
        grabable = false;
        grab = false;
        rend = GetComponent<Renderer>();
        gripCounter = 0;
        climber = GetComponent<Climber>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hand")
        {
            grabable = true;
            grab = true;
            Debug.Log("trigger enter");
            rend.material.color = Color.red;
        }
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    grabable = false;
    //    grab = true;
   //     Debug.Log("trigger exit");
   // }
    public void SetParent(GameObject newParent)
    {
        {

            if (grab == true)
            {
                Child2Transfer.transform.parent = newParent.transform;
                Debug.Log("Child2Transfer's Parent: " + Child2Transfer.transform.parent.name);
                
                character.enabled = false;
                if (newParent.transform.parent != null)
                {
                    Debug.Log("Child2Transfer's ground parent: " + Child2Transfer.transform.parent.parent.name);
                }
            }
        }
    }

    private void Update()
    {

    }

    public void SetParentOnFalse(GameObject newParent)
    {
        {
            if (gripCounter == 0)
            {
                Child2Transfer.transform.parent = newParent.transform;
                Debug.Log("Child2Transfer's Parent: " + Child2Transfer.transform.parent.name);
                grabable = false;
                grab = false;
                if (newParent.transform.parent != null)
                {
                    Debug.Log("Child2Transfer's ground parent: " + Child2Transfer.transform.parent.parent.name);
                }
            }
        }
    }

  public void gripCountAdd()
    {
        gripCounter += 1;
    }

    public void gripCountSubtract()
    {
        gripCounter -= 1;
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

    public void setZeroGrav()
    {
        if (grab == true)
        {
            continuousMovement.gravity = 0f;
            continuousMovement.fallingSpeed = 0f;
        }

    }

    public void enableChar()
    {
        if(grab == false)
        {
            character.enabled = true;
        }
    }

    public void disableChar()
    {
        if (grab == true)
        {
            character.enabled = false;
        }
    }

    public void setGrav()
    {
        if (grab == false)
        {
            continuousMovement.gravity = -9.81f;
        }
    }
}
