using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Image actorImage;
    public Text actorName;
    public Text messageText;
    public RectTransform bacgroundBox;

    Message[] currentMessages;
    Actor[] currentActors;

    int ActiveMessage = 0;
    public static bool isActive = false;

    public void OpenDialogue(Message[]messages, Actor[] actors) 
    {
        currentMessages = messages;
        currentActors = actors;
        ActiveMessage = 0;
        isActive = true;


        Debug.Log("Started conversation! Load messages:" + messages.Length);
        DisplayMessage();
        bacgroundBox.LeanScale(Vector3.one, 0.5f);
    }


    public void nextMessage() 
    {


        ActiveMessage++;

        if (ActiveMessage < currentMessages.Length)
        {

            DisplayMessage();

        }
        else 
        {

            Debug.Log("Conversation ended.");
            bacgroundBox.LeanScale(Vector3.zero, 0.5f).setEaseInOutExpo();
            isActive = false;

        }


    }


    private void Start()
    {
        bacgroundBox.transform.localScale = Vector3.zero;
    }


    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.LeftControl) ) && isActive) 
        {
            nextMessage();

        }
    }


    void DisplayMessage() 
    {

        Message messageToDisplay = currentMessages[ActiveMessage];
        messageText.text = messageToDisplay.message;

        Actor actorToDisplay = currentActors[messageToDisplay.actorId];
        actorName.text = actorToDisplay.name;
        actorImage.sprite = actorToDisplay.sprite;


    }
   

}
