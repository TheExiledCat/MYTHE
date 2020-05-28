using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool gameIsPaused = false;

    public GameObject PauseMenuUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            gameIsPaused = !gameIsPaused;
            Debug.Log("P was pressed");
        }
    }

    void Resume()
    {
        //PauseMenuUI.SetActive(false);
        //Time.timeScale = 1f;
    }
    void Pause()
    {
        //PauseMenuUI.SetActive(true);
        //Time.timeScale = 0f;
    }
}
