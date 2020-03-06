using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Sam Ferstein
 * WaveSpawner.cs
 * Assignment 7
 * This controls the waves and spawns enemies.
 */

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;
    public GameManager gameManager;
    public float timeBetweenWaves = 5.5f;
    private float countdown = 2;
    public static int waveNumber;
    public Text waveCountdownText;

    void Start()
    {
        waveNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.isGameActive == true)
        {
            if (countdown <= 0)
            {
                StartCoroutine(SpawnWave());
                countdown = timeBetweenWaves;
            }
            countdown -= Time.deltaTime;
            waveCountdownText.text = Mathf.Round(countdown).ToString();
        } 
    }

    IEnumerator SpawnWave()
    {
        waveNumber++;
        PlayerStats.Rounds++;

        for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
