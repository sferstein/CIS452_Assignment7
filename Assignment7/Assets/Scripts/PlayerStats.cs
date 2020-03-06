using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * PlayerStats.cs
 * Assignment 7
 * This gives the player their lives.
 */

public class PlayerStats : MonoBehaviour
{
    public static int Lives;
    public int startLives = 20;
    public static int Rounds;

    // Start is called before the first frame update
    void Start()
    {
        Lives = startLives;
        Rounds = 0;
    }
}
