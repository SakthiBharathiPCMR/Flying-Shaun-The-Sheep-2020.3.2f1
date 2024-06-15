using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            GamePlay();
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start");

    }

    public void GamePlay()
    {
        SceneManager.LoadScene("GamePlay");
    }

}
