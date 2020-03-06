using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Sam Ferstein
 * LivesUI.cs
 * Assignment 7
 * This changes the lives text.
 */

public class LivesUI : MonoBehaviour
{
    public Text livesText;

    // Update is called once per frame
    void Update()
    {
        livesText.text = PlayerStats.Lives.ToString() + " Lives";
    }
}
