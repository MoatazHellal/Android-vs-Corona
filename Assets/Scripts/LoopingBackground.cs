using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    [SerializeField]
    private float backgroundSpeed ;
    [SerializeField]
    private Renderer backgroundRenderer;
    
    // Update is called once per frame
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(- backgroundSpeed * Time.deltaTime ,0f );
    }
}
