using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadMenu : MonoBehaviour
{
    public bool PlayerIsDead = false;

    public GameObject DeadMenuUI;

    void Update()
    {
        if(PlayerIsDead == true)
        {
            DeadMenuUI.SetActive(true);
        }
        else if(PlayerIsDead == false)
        {
            DeadMenuUI.SetActive(false);
        }
    }
    
    public void Yes()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void No()
    {
        Application.Quit();
    }

    public void PlayerDied()
    {
        PlayerIsDead = true;
    }
}
