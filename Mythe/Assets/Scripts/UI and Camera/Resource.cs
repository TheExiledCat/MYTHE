using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource 
{
    protected float value;
    protected float maxValue;
    
    public void Init()
    {
        value = maxValue;
    }
    public virtual void StartDepleting(float amount)
    {
        value = value -amount < 0 ?  0:value-amount;
        if (value <= 0)
        {
            StopDepleting();
        }
    }
    public virtual void StopDepleting()
    {

    }
    public void SetMax(float amount)
    {
        maxValue = amount;
    }
    public float GetValue()
    {
        return value;
    }
}
