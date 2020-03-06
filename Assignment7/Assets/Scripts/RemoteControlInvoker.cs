using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * RemoteControlInvoker.cs
 * Assignment 7
 * This is the remote controller for the command pattern.
 */

public class RemoteControlInvoker : MonoBehaviour
{
    private GameObject turret;
    public Vector3 offset;
    private float numberSpawned;
    public BuildManagerMissile buildManagerMissile;
    public BuildManagerTurret buildManagerTurret;
    public BuildManager buildManager;
    Dictionary<float, Commands> commands;
    Stack<Commands> commandHistory;
    private Commands command;

    private void Start()
    {
        command = new BuildManagerMissile(buildManager);
        command = new BuildManagerTurret(buildManager);
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (turret != null)
            {
                Debug.Log("Can't build");
                return;
            }

            GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
            //turret = (GameObject)Instantiate(turretToBuild, transform.position + offset, transform.rotation);
            numberSpawned++;
            command.Execute(numberSpawned);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            command.Undo();
        }
    }

    public RemoteControlInvoker()
    {
        commands = new Dictionary<float, Commands>();
        commandHistory = new Stack<Commands>();
    }

    public void AddCommand(float number, Commands command)
    {
        commands.Add(number, command);
    }

    public void DisplayCommands()
    {
        Debug.Log("----- List of Commands in Remote Control -----\n");
        foreach (KeyValuePair<float, Commands> command in commands)
        {
            Debug.Log(command.Key + ": " + command.Value.GetType().Name + "\n");
        }
    }

    public void InvokeOrPressRemoteButton(float number)
    {
        commands.TryGetValue(number, out Commands command);
        if (command != null) { command.Execute(number); }

        commandHistory.Push(command);
    }

    public void InvokeUndoOrPressUndoButton()
    {
        if (commandHistory.Count != 0)
        {
            Debug.Log("Undoing...");
            Commands command = commandHistory.Pop();
            command.Undo();
        }
        else
        {
            Debug.Log("You tried to undo, but there are no more commands to undo.");
        }
    }

}
