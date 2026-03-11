using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticalSpawner : MonoBehaviour
{
    public GameObject obsticalePrefab;

    public GameObject[] obsticleInstances;
    public int numberOfInstances = 10;
    public int instanceIndex = 0;

    public float timeToSpawn;
    public float min = 2f;
    public float max = 4f;
    // Start is called before the first frame update
    void Start()
    {
        timeToSpawn = Random.Range(min, max);

        obsticleInstances = new GameObject[numberOfInstances];
        for (int i = 0; instanceIndex < numberOfInstances; i++)
        {
            obsticleInstances[i] = Instantiate(obsticalePrefab);
            obsticleInstances[i].transform.position = transform.position;
            obsticleInstances[i].SetActive(false);
        }
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
        obsticleInstances[instanceIndex].SetActive(true);
        obsticleInstances[instanceIndex].transform.position = transform.position;
        instanceIndex++;
        if (instanceIndex == numberOfInstances) instanceIndex = 0;
    }
}
