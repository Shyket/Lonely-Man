using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class TalkWithNarrator001 : MonoBehaviour
{
    public Vector3 narratorPossition;
    public DialogueManager dialogueManager;
    public Dialogue dialogue;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, narratorPossition) < 3)
        {
             startDialogueWithWill();
             Destroy(gameObject.GetComponent("TalkWithNarrator001"));
        }
    }

    private void startDialogueWithWill()
    {
        dialogueManager.startConversation(dialogue);
    }

}
