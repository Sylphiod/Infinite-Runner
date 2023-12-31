using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    public GameObject levelControl;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMove>().enabled = false;
        charModel.GetComponent<Animator>().Play("Root_Idle");
        levelControl.GetComponent<DistanceFull>().enabled = false;
        levelControl.GetComponent<Endrun>().enabled = true;

    }
}
