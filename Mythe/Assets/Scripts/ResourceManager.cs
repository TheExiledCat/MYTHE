using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    // Start is called before the first frame update

    public RechargingResource stamina;
    [SerializeField]
    float timer;//time it takes to start regen
  
    [SerializeField]
    float changeSpeed;
    void Start()
    {
        stamina = new RechargingResource();
        stamina.SetMax(Constants.RESOURCE_MAX);
        stamina.Init();
    }

    // Update is called once per frame
    void Update()
    {
        print(stamina.GetValue());
        DepleteStamina(changeSpeed);
        stamina.CheckTimer(timer);
        stamina.Recharge(changeSpeed/2);
    }

    public void DepleteStamina(float exhaustion)
    {
        stamina.StartDepleting(exhaustion);
    }
    public void StopDepletingStamina()
    {
        stamina.StopDepleting();
    }
}
