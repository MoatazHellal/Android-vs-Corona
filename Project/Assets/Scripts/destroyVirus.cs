using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyVirus : MonoBehaviour
{
    [SerializeField]
    GameObject impactPrefab;
    public static int i;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player" )
        {
            Destroy(gameObject);
            Instantiate( impactPrefab , transform.position , Quaternion.identity);
            Destroy(FindObjectOfType<Hp>().hp[i]);
            i--;
            FindObjectOfType<AudioManager>().Play("Boom");
        }
        if (collider.tag == "Rocket")
        {
            Destroy(gameObject);
            Destroy(collider.gameObject);
            Instantiate( impactPrefab , transform.position , Quaternion.identity);
            FindObjectOfType<AudioManager>().Play("Boom");
        }
    }
}
