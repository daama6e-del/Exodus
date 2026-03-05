using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticalSpawner : MonoBehaviour
{
    public GameObject obsticalePrefab;
    public float timeToSpawn;
    public float min = 2f;
    public float max = 4f;
    // Start is called before the first frame update
    void Start()
    {
        timeToSpawn = Random.Range(min, max);
    }

    // Update is called once per frame
    void Update()
    {
        timeToSpawn -= Time.deltaTime;
        if (timeToSpawn <= 0.0f)
        {
            SpawnObstacle();
            timeToSpawn = Random.Range(min, max);
        }
    }

    void SpawnObstacle()
    {
        Instantiate(obsticalePrefab, transform.position, Quaternion.identity);
    }
}
