using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;


public class GemCollector : MonoBehaviour
{

    private int Gems = 0;

    [SerializeField] private Text Scoreboard;

    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.gameObject.CompareTag("Gems")) 
        { 
            Destroy(Collision.gameObject);
            Gems++;
            Scoreboard.text = "Gems: " + Gems;
            AudioManager.instance.Play("GemCollect");

        }
    }
}
