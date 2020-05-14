using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        print(col.gameObject);
        if (col.gameObject.CompareTag("Player"))
        {
            print("GAME DONE");
            End();
        }
    }
    void End()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
