using System.Collections;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public EnemyWave[] waves;
    private GameObject[] spawners;

    private int currentWaveIndex = 0;
    private bool isSpawning = false;

    void Start()
    {
        spawners = GameObject.FindGameObjectsWithTag("EnemySpawner");
    }

    void Update()
    {
        if (!isSpawning && currentWaveIndex < waves.Length)
        {
            StartCoroutine(SpawnWave(waves[currentWaveIndex]));
            currentWaveIndex++;
        }
    }

    void Spawn(Transform transform, GameObject enemy)
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }

    IEnumerator SpawnWave(EnemyWave wave)
    {
        isSpawning = true;

        for (int i = 0; i < wave.count; i++)
        {
            Spawn(spawners[Random.Range(0, spawners.Length)].transform, wave.enemyPrefab);

            yield return new WaitForSeconds(1f / wave.spawnRate);
        }

        isSpawning = false;
    }
}
