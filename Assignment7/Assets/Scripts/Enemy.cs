using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Sam Ferstein
 * Enemy.cs
 * Assignment 7
 * This is the enemy prefab code.
 */

public class Enemy : MonoBehaviour
{
    public float speed = 20;
    public int startHealth = 100;
    private float health;
    private Transform target;
    private int wavepointIndex = 0;
    public Image healthBar;
    private bool isDead = false;

    void Start()
    {
        target = Waypoints.waypoints[0];
        health = startHealth;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;

        healthBar.fillAmount = health / startHealth;

        if(health <= 0 && !isDead)
        {
            Die();
        }
    }

    void Die()
    {
        isDead = true;
        Destroy(gameObject);
    }

    void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if(wavepointIndex >= Waypoints.waypoints.Length - 1)
        {
            EndPath();
            return;
        }

        wavepointIndex++;
        target = Waypoints.waypoints[wavepointIndex];
    }

    void EndPath()
    {
        PlayerStats.Lives--;
        Destroy(gameObject);
    }
}
