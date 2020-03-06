using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Sam Ferstein
 * WavesUI.cs
 * Assignment 7
 * This controls the wave counter.
 */

public class WavesUI : MonoBehaviour
{
    public Text wavesText;

    // Update is called once per frame
    void Update()
    {
        wavesText.text = "Wave " + WaveSpawner.waveNumber.ToString();
    }
}
