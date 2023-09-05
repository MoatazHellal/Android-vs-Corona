using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
        GameObject obstaclePrefab , CoronaPrefab;
    [SerializeField]
        private float minX,minY,maxX,maxY;
    [SerializeField]
        float timeBetweenSpawn;
    [SerializeField]
        float coronaSpawnTime;
    [SerializeField]
        Transform GameManager;
        float spawnTime ;
        bool coronaSpawned = false;
        
    

    // Update is called once per frame
    void Update()
    {
        if ( Time.time > spawnTime )
        {
            spawn();
            spawnTime = Time.time + timeBetweenSpawn ;
        }
        if (!coronaSpawned && Time.timeSinceLevelLoad > coronaSpawnTime)
        {
            spawnCorona();
        }
    }
    void spawn()
    {
        float randomX = Random.Range(minX,maxX);
        float randomY = Random.Range(minY,maxY);
        GameObject obstacle = Instantiate(obstaclePrefab , transform.position + new Vector3(randomX , randomY , 0) , Quaternion.identity);
        Destroy(obstacle,5);
    }
    void spawnCorona()
    {
        Instantiate(CoronaPrefab , transform.position , Quaternion.identity , GameManager);
        coronaSpawned = true;
        timeBetweenSpawn = 0.2f;
    }
}
