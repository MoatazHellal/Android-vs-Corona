using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyCorona : MonoBehaviour
{
    [SerializeField]
    private int Hp;
    [SerializeField]
    GameObject rocketImpact,deathImpact ;
    public static bool CoronaDead;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Rocket")
        {
            Hp--;
            Instantiate(rocketImpact , collider.gameObject.transform.position + new Vector3(-2,0,0) , Quaternion.identity);
            Destroy(collider.gameObject);
            FindObjectOfType<AudioManager>().Play("Boom");
        }
    }
    void Update()
    {
        if ( Hp == 0)
        {
            Destroy(gameObject);
            Instantiate(deathImpact , transform.position + new Vector3(-1,0,0)  , Quaternion.identity);
            FindObjectOfType<AudioManager>().Play("Boom");
            CoronaDead = true ;
        }
    }
    

}
