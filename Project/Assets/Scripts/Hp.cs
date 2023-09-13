using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp : MonoBehaviour
{
    public GameObject[] hp ;
    [SerializeField]
    GameObject hpPrefab , GameManager;
    void Start()
    {
        destroyVirus.i=2;
        hp[0] = Instantiate(hpPrefab , new Vector3(-14,-7,-1) , Quaternion.identity , GameManager.transform);
        hp[1] = Instantiate(hpPrefab , new Vector3(-13,-7,-1) , Quaternion.identity , GameManager.transform);
        hp[2] = Instantiate(hpPrefab , new Vector3(-12,-7,-1) , Quaternion.identity , GameManager.transform);
    }
    
}
