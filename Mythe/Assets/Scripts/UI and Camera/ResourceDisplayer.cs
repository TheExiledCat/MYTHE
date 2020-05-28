using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResourceDisplayer : MonoBehaviour
{
    [SerializeField]
    ResourceManager rm;
    float stamina;
    float mana;
    [SerializeField]
    Image staminaBar;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        stamina = rm.stamina.GetValue();
        staminaBar.fillAmount = stamina / Constants.RESOURCE_MAX;
    }
}
