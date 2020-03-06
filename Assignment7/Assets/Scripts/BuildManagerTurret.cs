using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * BuildManagerTurret.cs
 * Assignment 7
 * This is one of the conrete commands for the command pattern.
 */

public class BuildManagerTurret : Commands
{
    BuildManager buildManager;

    Stack<float> numberSpawned;

    public BuildManagerTurret(BuildManager buildManager)
    {
        this.buildManager = buildManager;
        numberSpawned = new Stack<float>();
    }

    public void Execute(float number)
    {
        numberSpawned.Push(buildManager.GetNumberSpawned());

        buildManager.BuildManagerTurret(number);
    }

    public void Undo()
    {
        if (numberSpawned != null)
        {
            buildManager.BuildManagerTurret(numberSpawned.Pop());
        }
        else
        {
            Debug.Log("Can't undo anymore");
        }
    }
}
