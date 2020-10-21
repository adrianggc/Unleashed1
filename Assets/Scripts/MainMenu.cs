﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string FreeRoamScene;
    public string QuickRaceScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FreeRoam()
    {
        SceneManager.LoadScene(FreeRoamScene);
    }

    public void QuickRace()
    {
        SceneManager.LoadScene(QuickRaceScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
