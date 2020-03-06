using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * RemoteLoader.cs
 * Assignment 7
 * This is the remote loader for the command pattern.
 */

public class RemoteLoader : MonoBehaviour
{
    private GameObject turret;
    // Start is called before the first frame update
    void Start()
    {
        RemoteControlInvoker remoteControlInvoker = new RemoteControlInvoker();

        BuildManager buildManager = new BuildManager(turret);

        BuildManagerMissile buildManagerMissile = new BuildManagerMissile(buildManager);
        BuildManagerTurret buildManagerTurret = new BuildManagerTurret(buildManager);

        remoteControlInvoker.AddCommand(1, buildManagerMissile);
        remoteControlInvoker.AddCommand(1, buildManagerTurret);
        remoteControlInvoker.AddCommand(2, buildManagerMissile);
        remoteControlInvoker.AddCommand(2, buildManagerTurret);
        remoteControlInvoker.AddCommand(3, buildManagerMissile);
        remoteControlInvoker.AddCommand(3, buildManagerTurret);
        remoteControlInvoker.AddCommand(4, buildManagerMissile);
        remoteControlInvoker.AddCommand(4, buildManagerTurret);
        remoteControlInvoker.AddCommand(5, buildManagerMissile);
        remoteControlInvoker.AddCommand(5, buildManagerTurret);

        remoteControlInvoker.DisplayCommands();

        remoteControlInvoker.InvokeOrPressRemoteButton(0);
        remoteControlInvoker.InvokeOrPressRemoteButton(1);
        remoteControlInvoker.InvokeOrPressRemoteButton(2);
        remoteControlInvoker.InvokeOrPressRemoteButton(3);
        remoteControlInvoker.InvokeOrPressRemoteButton(4);
        remoteControlInvoker.InvokeOrPressRemoteButton(5);
        remoteControlInvoker.InvokeUndoOrPressUndoButton();
        remoteControlInvoker.InvokeUndoOrPressUndoButton();
        remoteControlInvoker.InvokeUndoOrPressUndoButton();
        remoteControlInvoker.InvokeUndoOrPressUndoButton();
        remoteControlInvoker.InvokeUndoOrPressUndoButton();
    }
}
