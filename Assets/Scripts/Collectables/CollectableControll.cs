using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
public class CollectableControll : MonoBehaviour
{
    public static int coinCount;
    public GameObject coinCountDisplay;
    public GameObject coinEndDisplay;

    void Update()
    {
        coinCountDisplay.GetComponent<Text>().text = "" + coinCount;
        coinEndDisplay.GetComponent<Text>().text = "" + coinCount;
        if (GameManager.connectedToGooglePlay)
        {
            Social.ReportScore(coinCount, GPGSIds.leaderboard_infinnirunner, LeaderboardUpdate);
        }
    }

    void LeaderboardUpdate(bool success)
    {
        if (success)
        {
            Debug.Log("Updated Leaderboard");
        }
        else Debug.Log("Unable to Update Leaderboard");

    }

}
