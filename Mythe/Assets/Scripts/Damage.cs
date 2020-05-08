using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Damage : MonoBehaviour
{
    
    public void Hurt()
    {
        Die();
    }
    void Die()
    {
        print("DEAD");
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
