using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * BuildManagerMissile.cs
 * Assignment 7
 * This is one of the conrete commands for the command pattern.
 */

public class BuildManagerMissile : Commands
{
    BuildManager buildManager;

    Stack<float> numberSpawned;

    public BuildManagerMissile(BuildManager buildManager)
    {
        this.buildManager = buildManager;
        numberSpawned = new Stack<float>();
    }

    public void Execute(float number)
    {
        numberSpawned.Push(buildManager.GetNumberSpawned());

        buildManager.BuildManagerMissile(number);
    }

    public void Undo()
    {
        if(numberSpawned != null)
        {
            buildManager.BuildManagerMissile(numberSpawned.Pop());
        }
        else
        {
            Debug.Log("Can't undo anymore");
        }
    }
}
