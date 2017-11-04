﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This controller inherits from the options controller since the pause menu is pretty much the same
/// as the options menu but with some extra functionalities such as pausing
/// </summary>
public class PauseController : OptionsController {
    public GameObject pausePanel;
    public bool gameIsPaused;
	// Use this for initialization
	void Start () {
        //Game is default not paused
        gameIsPaused = false;
	}
	
	// Update is called once per frame
	void Update () {
        //Get keyboard input for the esc key. Flip bool whenever the player presses it
        if (Input.GetKeyDown(KeyCode.Escape))
            gameIsPaused = !gameIsPaused;

        //Either pause the game or unpause the game depending on the bool
        if (gameIsPaused)
            PauseGame();
        else
            UnPauseGame();

	}
    //Unpause the game. Sets time scale, enables the panel, and sets bool
    public void PauseGame()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        gameIsPaused = true;
    }
    //Unpause the game. Resets time scale, disables the panel, and sets bool
    public void UnPauseGame()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        gameIsPaused = false;
    }
    //Load a new scene
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
