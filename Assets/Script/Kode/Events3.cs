using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Events3 : MonoBehaviour
{
    // Start is called before the first frame update
    public void ReplayGame()
    {
        SceneManager.LoadScene("LVLMEDIUM");
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }
}
