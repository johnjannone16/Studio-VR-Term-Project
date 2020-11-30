using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class PushScript : MonoBehaviour
{
    public Rigidbody pushObject;
    public InputDevice hand;
    public float pushForce = 0f;
    public float pushBuild = 1.5f;
    public XRController pushingHandRight;
    public XRController pushingHandLeft;
    private bool triggerPress;

    private void Update()
    {
        hand.TryGetFeatureValue(CommonUsages.triggerButton, out triggerPress);
        
    }


     
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Hand"))
        {
            Debug.Log("Hand is in Push Zone");
            pushRight();
            
        }
    }


    private void pushRight()
    {
        bool button;
        if (InputDevices.GetDeviceAtXRNode(pushingHandRight.controllerNode).TryGetFeatureValue(CommonUsages.triggerButton, out button) && button)
        {
            uint channel = 0;
            float amplitude = 0.5f;
            float duration = 1.0f;
            InputDevices.GetDeviceAtXRNode(pushingHandRight.controllerNode).SendHapticImpulse(channel, amplitude, duration);
            pushForce = 1f + pushForce * pushBuild;
            if (pushForce >= 250f)
            {
                pushForce = 250f;
            }
            
        }
        else
        {
            pushObject.AddForce(0, 0, -pushForce, ForceMode.Impulse);
            pushForce = 0f;
            
        }
    }

    private void pushLeft()
    {
        bool button;
        if (InputDevices.GetDeviceAtXRNode(pushingHandLeft.controllerNode).TryGetFeatureValue(CommonUsages.triggerButton, out button) && button)
        {
            uint channel = 0;
            float amplitude = 0.5f;
            float duration = 1.0f;
            InputDevices.GetDeviceAtXRNode(pushingHandLeft.controllerNode).SendHapticImpulse(channel, amplitude, duration);
            pushForce = 1f + pushForce * pushBuild;
            if (pushForce >= 250f)
            {
                pushForce = 250f;
            }

        }
        else
        {
            pushObject.AddForce(0, 0, -pushForce, ForceMode.Impulse);
            pushForce = 0f;

        }
    }
}
