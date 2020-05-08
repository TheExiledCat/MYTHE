using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BoxCollider))]
public class StationaryTrap : Trap
{
    [SerializeField]
    Vector3 center;
    [SerializeField]
    Vector3 extents;
    
    void FixedUpdate()
    {
        Collider[] col = Physics.OverlapBox(center, extents,transform.rotation,Constants.PLAYER_LAYER);
        if (col.Length > 0)
        {
            DamageCollider(col[0]);
        }









    }
}
