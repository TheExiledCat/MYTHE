using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserColliders : Trap
{
    LaserPositioner lp;
    [SerializeField]
    List<Collider[]> hitboxes = new List<Collider[]>();
    
    [SerializeField]
    float radius;
    void Start()
    {
        lp = GetComponent<LaserPositioner>();
        for(int i=0; i < lp.points.Length; i++)
        {
            hitboxes.Add(new Collider[1]);
        }
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        for(int i = 0; i < hitboxes.Count; i++)
        {
            if (i == hitboxes.Count - 1)
            {
                hitboxes[i] = Physics.OverlapCapsule(lp.points[i].position, lp.points[0].position, radius, Constants.PLAYER_LAYER);
            }
            else
            {
                hitboxes[i] = Physics.OverlapCapsule(lp.points[i].position, lp.points[i + 1].position, radius, Constants.PLAYER_LAYER);
            }
            if (hitboxes[i].Length > 0)
                DamageCollider(hitboxes[i][0]);
        }

       
    }
    
}
