using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    GameObject RocketPrefab;
    [SerializeField]
    float rocketSpeed;
    [SerializeField]
    float rocketCD;
    float lastRocketTime;
    void Start()
    {
        lastRocketTime = Time.time;
    }
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.Space) &&  ( Time.time - lastRocketTime > rocketCD))
        {
            GameObject rocket = Instantiate(RocketPrefab , transform.position + new Vector3(-4.5f,0,0) , Quaternion.identity);
            rocket.GetComponent<Rigidbody2D>().velocity = new Vector2(-rocketSpeed,0);
            lastRocketTime = Time.time;
        }
            
    }
}
