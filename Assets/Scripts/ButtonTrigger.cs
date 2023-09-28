using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public Animator anim;
    private bool isDialogueFirst = false;
    public GameObject delButton;



    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.CompareTag("Player") && isDialogueFirst == false)
        {   
            isDialogueFirst = true;
            anim.SetTrigger("isTriggered");
            
        }
        
    }



    private void OnTriggerExit2D(Collider2D other)
    {

        if(other.CompareTag("Player"))
        {
            anim.SetTrigger("isTriggered");
        }
        
    }





}
