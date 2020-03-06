using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * BuildManager.cs
 * Assignment 7
 * This is the receiver class for the command pattern.
 */

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    public GameObject standardTurretPrefab;
    public GameObject missileLauncherPrefab;

    private GameObject turretToBuild;
    private float numberSpawned;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("Too many build managers");
            return;
        }
        instance = this;
    }

    public BuildManager(GameObject objectToBuild)
    {
        this.turretToBuild = objectToBuild;
        this.numberSpawned = 0;
    }

    private void Update()
    {
        if(Input.GetKeyDown("1"))
        {
            SetTurretToBuild(standardTurretPrefab);
        }
        if (Input.GetKeyDown("2"))
        {
            SetTurretToBuild(missileLauncherPrefab);
        }
    }

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    private void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }

    public float GetNumberSpawned()
    {
        return this.numberSpawned;
    }

    public void BuildManagerTurret(float number)
    {
        Debug.Log("Spawning Turret");
        SetTurretToBuild(standardTurretPrefab);
        numberSpawned = number;
    }

    public void BuildManagerMissile(float number)
    {
        Debug.Log("Spawning Missile");
        SetTurretToBuild(missileLauncherPrefab);
        numberSpawned = number;
    }
}
