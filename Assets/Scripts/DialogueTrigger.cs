using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueManager dialogueManager;
    public Dialogue dialogue;

    private void Start()
    {
    }

    private void OnMouseDown()
    {
        dialogueManager.startConversation(dialogue);   
        
    }


    


}
