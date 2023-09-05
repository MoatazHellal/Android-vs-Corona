using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoement : MonoBehaviour
{
    [SerializeField]
    private float cameraSpeed ;
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3 ( -cameraSpeed * Time.deltaTime , 0 , 0);
    }
}
