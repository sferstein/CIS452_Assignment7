using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * GameManager.cs
 * Assignment 7
 * This manages the game.
 */

public class GameManager : MonoBehaviour
{
    private bool gameEnded;
    public bool isGameActive;

    public GameObject gameOver;
    public GameObject gameWon;
    public GameObject titleScreen;
    public GameObject gameUI;

    void Start()
    {
        isGameActive = false;
        gameEnded = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameEnded)
            return;
        

        if(PlayerStats.Lives <= 0)
        {
            EndGame();
        }
        if (WaveSpawner.waveNumber >= 10)
        {
            WinGame();
        }
    }

    public void StartGame()
    {
        isGameActive = true;
        titleScreen.SetActive(false);
        gameUI.SetActive(true);
    }

    void EndGame()
    {
        gameEnded = true;
        gameOver.SetActive(true);
    }

    public void WinGame()
    {
        gameEnded = true;
        gameWon.SetActive(true);
    }

}
