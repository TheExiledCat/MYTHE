﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationaryTrap : Trap
{
    [SerializeField]
    Vector3 center;
    [SerializeField]
    Vector3 extents;
    
    void FixedUpdate()
    {
        Collider[] col = Physics.OverlapBox(center+transform.position, extents,transform.rotation,Constants.PLAYER_LAYER);
        if (col.Length > 0)
        {
            
            DamageCollider(col[0]);
        }

    }
    void OnDrawGizmos()
    {
    
        Gizmos.DrawWireCube(center+transform.position, extents);
    }
}
