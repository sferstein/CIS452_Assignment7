using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * Node.cs
 * Assignment 7
 * This controls the nodes on the map.
 */

public class Node : MonoBehaviour
{
    public Color hoverColor;
    private Renderer rend;
    private Color startColor;
    public Vector3 offset;
    public GameManager gameManager;

    private GameObject turret;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    private void OnMouseDown()
    {
        if(gameManager.isGameActive == true)
        {
            if (turret != null)
            {
                Debug.Log("Can't build");
                return;
            }

            GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
            turret = (GameObject)Instantiate(turretToBuild, transform.position + offset, transform.rotation);
        }
    }

    private void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
