using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool gameIsPaused = false;

    public GameObject PauseMenuUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Resume();
        }
    }

    public void Resume()
    {
        gameIsPaused = !gameIsPaused;
        Debug.Log("P was pressed");
        if (gameIsPaused == true)
        {
            PauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (gameIsPaused == false)
        {
            PauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
        }
    }
    public void Exit()
    {
        Application.Quit();
    }
}
