using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    Hp hp ;
    [SerializeField]
    Animator transition;
    bool gameOver;
    [SerializeField]
    float transitionTime;
    [SerializeField]
    GameObject LossMenu , WinMenu , panel , impact , player;
    // Start is called before the first frame update
    void Start()
    {
        destroyCorona.CoronaDead = false;
        gameOver = false ;
         hp = FindObjectOfType<Hp>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if ( destroyCorona.CoronaDead && !gameOver )
        {
            StartCoroutine(win());
        }
        if (hp.hp[0] == null && !gameOver ) 
        {
            StartCoroutine(lose());
        }
    }
    public void replay()
    {
        Time.timeScale = 1;
        StartCoroutine(mainMenu());
    }
    IEnumerator win()
    {
        gameOver = true ;
        yield return new WaitForSeconds(1f);
        Time.timeScale = 0;
        panel.SetActive(true);
        WinMenu.SetActive(true);
    }
    IEnumerator lose()
    {
        gameOver = true ;
        Instantiate(impact , player.transform.position , Quaternion.identity);
        player.SetActive(false);
        yield return new WaitForSeconds(1f);
        Time.timeScale = 0;
        panel.SetActive(true);
        LossMenu.SetActive(true);
    }
    IEnumerator mainMenu ()
    {
        transition.SetBool("LoadNext",true);
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1 , LoadSceneMode.Single);
    }
}
