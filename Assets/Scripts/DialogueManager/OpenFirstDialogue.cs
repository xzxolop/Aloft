using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFirstDialogue : MonoBehaviour
{
    private bool IsShowed = false;
    private DialogueTrigger DialogueTrigger;
    private void Start()
    {
      DialogueTrigger = GetComponent<DialogueTrigger>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && IsShowed == false)
        {
            IsShowed = true;
            DialogueTrigger.StartDialogue();

        }
    }
}
