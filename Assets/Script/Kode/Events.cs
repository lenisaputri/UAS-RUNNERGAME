﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Events : MonoBehaviour
{
    // Start is called before the first frame update
    public void ReplayGame()
    {
        SceneManager.LoadScene("LVLEASY");
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }
}
