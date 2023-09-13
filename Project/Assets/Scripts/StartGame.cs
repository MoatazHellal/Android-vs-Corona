using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField]
    Animator TransitionMask;
    [SerializeField]
    float transitionTime;
    public void startGame()
    { 
       StartCoroutine(loadLevel());
    }
    IEnumerator loadLevel ()
    {
        TransitionMask.SetBool("LoadNext",true);
        yield return new WaitForSecondsRealtime(transitionTime);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 , LoadSceneMode.Single);
    }
}
