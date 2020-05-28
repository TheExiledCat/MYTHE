using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MeshCollider))]
public class MovingTrap : Trap
{
    void OnTriggerEnter(Collider col)
    {
        DamageCollider(col);
    }
}
