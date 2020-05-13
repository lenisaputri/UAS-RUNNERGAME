using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Events2 : MonoBehaviour
{
    // Start is called before the first frame update
    public void ReplayGame()
    {
        SceneManager.LoadScene("LVLHARD");
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }
}
