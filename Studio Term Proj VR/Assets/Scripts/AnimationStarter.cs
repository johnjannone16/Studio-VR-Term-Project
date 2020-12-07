using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStarter : MonoBehaviour
{
    public Animator animator1;
    public Animator animator2;
    public AudioSource whispers;
    public AudioSource wood;
    //public Renderer rend;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("AnimationStarter"))
        {
            Debug.Log("Animation Start");
            //rend.material.color = Color.red;
            animator1.SetFloat("Blend", 0);
            animator2.SetFloat("Blend", 0);
            whispers.Stop();
            wood.Play();
        }
    }

    
}
