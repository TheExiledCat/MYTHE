using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RechargingResource : Resource
{
    float startTime;
    bool regenerating;
    bool charging = false;
    // Update is called once per frame
    public void Recharge(float amount)
    {
        if (charging)
        {
            value += amount;
           
             
            if (value >= Constants.RESOURCE_MAX)
            {
                value = Constants.RESOURCE_MAX;
                regenerating = false;
                charging = false;
            }
        }
        
    }
    
    public override void StartDepleting(float amount)
    {
        if (!regenerating)
        {
            base.StartDepleting(amount);
        }
        

    }
    public override void StopDepleting()
    {
        regenerating = true;
        startTime = Time.time;
    }
    public void CheckTimer(float timer)
    {
        
        if (Time.time - startTime >= timer&&regenerating)
        {
            charging = true;
            
        }
       
    }
}
