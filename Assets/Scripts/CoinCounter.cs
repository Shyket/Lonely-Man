using System;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public static int numOfCoin;
    private void Start()
    {
        numOfCoin = 0;
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10,10,90,40), ("Coins: " + numOfCoin));
    }

}
