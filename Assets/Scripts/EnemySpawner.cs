using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject eyeballPrefab;
    [SerializeField] float timeBetweenSpawns;  // FIXED: Changed GameObject to float

    float elapsedSinceLastSpawn = 0;

    void Start()
    {
        //InvokeRepeating("SpawnEyeball", 1, 2);
    }

    void Update()
    {
        elapsedSinceLastSpawn += Time.deltaTime;

        if (elapsedSinceLastSpawn > timeBetweenSpawns)
        {
            SpawnEyeball();
            elapsedSinceLastSpawn = 0;
        }
    }

    void SpawnEyeball()
    {
        int ry = Random.Range(-20, 20);
        Vector3 position = new Vector3(0, ry, 0);  // FIXED: Removed duplicate
        Instantiate(eyeballPrefab, position, Quaternion.identity);
    }
}
