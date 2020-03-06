using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * Commands.cs
 * Assignment 7
 * This is the command class for the command pattern.
 */

public interface Commands
{
    void Execute(float number);
    void Undo();
}
