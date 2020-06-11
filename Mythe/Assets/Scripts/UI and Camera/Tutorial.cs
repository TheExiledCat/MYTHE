using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject TutorialImages;
    public float Timer;
    public bool TutorialOn;
    bool done = false;
    void Start()
    {
        TutorialOn = false;
    }

    private void Update()
    {
        if(TutorialOn == true)
            Timer -= Time.unscaledDeltaTime;

        if(Timer <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                TutorialImages.SetActive(false);
                TutorialOn = false;
                Time.timeScale = 1;
                done = true;
            }
           
        }

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player")&&!done)
        {
            TutorialImages.SetActive(true);
            TutorialOn = true;
            Time.timeScale = 0;
        }
        Debug.Log(col);
    }
}
