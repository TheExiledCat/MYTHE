using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePuzzle : MonoBehaviour
{   
    [SerializeField]
    Gate gate;

    int index = 0;
   
    
    private bool done = false;
    
    
    [Header("Game Objects and Audio sources of Heads in order of happy to angry")]
    [SerializeField]
    GameObject[] heads = new GameObject[4];
    AudioSource[] sources = new AudioSource[4];
    [SerializeField] AudioClip failSound;
    void Start()
    {
        for(int i = 0; i < heads.Length; i++)
        {
            sources[i] = heads[i].transform.parent.GetComponent<AudioSource>();
        }
        print(index);
    }
   
   

    void Complete()
    {

        print("Done");
        done = true;
        gate.Open();
        
        
    }

    void OnCollisionEnter(Collision col)
    {

        int layer = Constants.TOTEM_LAYER >> col.gameObject.layer;
        
        if (layer==1 &&!done)
        {
            print(col.gameObject);
            if (col.gameObject == heads[index])
            {
                sources[index].Play();
                NextTotem();
            } else if ((index > 0 && col.gameObject != heads[index - 1]) || (index == 0 && col.gameObject != heads[index]))
            {
                Restart();
            }
            
        }

    }
    void Restart()
    {
        index = 0;
        print("wrong");
        sources[0].PlayOneShot(failSound);
        print(index);
    }
    void NextTotem()
    {
        if (index < heads.Length-1)
        {
            index++;
        }
        else
        {
            Complete();
        }
        print(index);
    }
}
