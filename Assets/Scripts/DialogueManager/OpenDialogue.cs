using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDialogue : MonoBehaviour
{

    public Animator animator;


    public void OpenDialogueBox() 
    {
        animator.SetTrigger("Triggered");
    }


}
