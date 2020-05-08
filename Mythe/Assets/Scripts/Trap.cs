using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
   protected void DamageCollider(Collider col)
    {
        if (col.GetComponent<Damage>() != null)
        {
            col.GetComponent<Damage>().Hurt();
        }
    }
}
