using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> dialogueSentences;
    public TextMeshProUGUI convText;
    public GameObject convPanel;
    public GameObject button;
    public float typingSpeed;
    public TextMeshProUGUI objText;

    void Start()
    {
        dialogueSentences = new Queue<string>();
    }

    public void setObjective(string obj)
    {
        if (obj.Equals(null))
        {
            objText.text = "(none)";
        }
        objText.text = obj;
    }

    public void startConversation(Dialogue dialogue)
    {     
        foreach (string sentence in dialogue.sentences)
        {
           
            dialogueSentences.Enqueue(sentence);
        }
        loadSentence();
    }

    public void loadSentence()
    {
        convText.text = null;

        if (dialogueSentences.Count == 0)
        {
            button.SetActive(false);
            convPanel.SetActive(false);

            return;
        }
        if (!convPanel.activeSelf)
        {
            convPanel.SetActive(true);
        }
        char[] currentText = dialogueSentences.Dequeue().ToCharArray();
        StartCoroutine(addWordsToEditor(currentText));
    }

    IEnumerator addWordsToEditor(char[] currentText)
    {
        foreach (char c in currentText)
        {
            button.SetActive(false);
            convText.text += c;
            yield return new WaitForSeconds(typingSpeed);
        }

        button.SetActive(true); 
    }

   
}
