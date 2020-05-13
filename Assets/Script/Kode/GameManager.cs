using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject panelPause;

    public bool gamePaused = false;

    public void PauseControl()
    {
        if(gamePaused == false)
        {
            panelPause.SetActive(true);
            Time.timeScale = 0;
            gamePaused = true;
        }
        else
        {
            Time.timeScale = 1;
            panelPause.SetActive(false);
            gamePaused = false;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void MenuLevel()
    {
        Application.LoadLevel(2);
    }
}
