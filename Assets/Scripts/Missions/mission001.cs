using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;
using Object = System.Object;

public class mission001 : MonoBehaviour
{
    public DialogueManager dialogueManager;
    public GameObject player;
    public string missionObjective;
    public GameObject narrator;
    public List<Transform> markers;
    public GameObject objective;

    public void Start()
    {
        OnMissionStart();
    }

    void OnMissionStart()
    {
        //initiate narrator
        if (narrator.activeSelf)
        {
            narrator.SetActive(true);
        }

        //talk with narrator
       TalkWithNarrator001 talk = player.AddComponent<TalkWithNarrator001>();

        //if talks, active objective
       if (talk != null)
        {
            if (!objective.activeSelf)
            {
                objective.SetActive(true);
            }

            dialogueManager.setObjective(missionObjective);

            CompleteTheObjective complete = player.AddComponent<CompleteTheObjective>();
            if(complete != null)
            {
                talk = player.AddComponent<TalkWithNarrator001>();
               
            }
        }
    }

    private void returnToWill()
    {

    }

    
}
