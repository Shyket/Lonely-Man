using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> missionList;
    public static GameManager gameManager { get; private set; }
    private GameObject currentMission;
    private int currentMissionNumber;
    void Start()
    {
        currentMissionNumber = 0;
        loadNewMission();

    }

    private void Awake()
    {
        gameManager = this;
    }

    public void onMissionComplete()
    {
        currentMission.SetActive(false);
        loadNewMission();
    }

    private void loadNewMission()
    {
        currentMission = missionList.ElementAt(currentMissionNumber);
        ++currentMissionNumber;
        currentMission.SetActive(true);
    }
}
