using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * Waypoints.cs
 * Assignment 7
 * This is to set the waypoints for the enemies.
 */

public class Waypoints : MonoBehaviour
{
    public static Transform[] waypoints;

    private void Awake()
    {
        waypoints = new Transform[transform.childCount];
        for(int i = 0; i < waypoints.Length; i++)
        {
            waypoints[i] = transform.GetChild(i);
        }
    }
}
