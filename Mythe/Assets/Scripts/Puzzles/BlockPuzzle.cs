using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPuzzle : MonoBehaviour
{
    [SerializeField]
    GameObject[] blocks;
    Rigidbody[] blockBodies;
    [SerializeField]
    Collider[] cols;
    // Start is called before the first frame update
    [SerializeField]
    Vector3 origin, extents;
    [SerializeField]
    Gate gate;
    int numberOfBlocks = 0;
    
    Pickup p;
    void Start()
    {
        p = GameObject.FindGameObjectWithTag("Player").GetComponent<Pickup>();
        blockBodies = new Rigidbody[blocks.Length];
        int i = 0;
        foreach (GameObject g in blocks)
        {
            blockBodies[i] = g.GetComponent<Rigidbody>();
            i++;
        }
    }
    // Update is called once per frame
    void Update()
    {
        numberOfBlocks = 0;
        cols = Physics.OverlapBox(transform.position+origin, extents, Quaternion.identity, Constants.SELECTABLE_LAYER);
        foreach (GameObject g in blocks)
        {
            if (ContainsBlock(g))
            {
                numberOfBlocks++;

            }
        }
        if (numberOfBlocks == blocks.Length && p.selected == null)
        {
            Finish();
            enabled = false;
        }

    }
    void Finish()
    {
        foreach (Rigidbody r in blockBodies)
        {
           r.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
           r.freezeRotation = true;
            r.isKinematic = true;
        }
        gate.Open();
    }
    void OnDrawGizmos()
    {
        
        Gizmos.DrawWireCube(transform.position+origin, extents);
    }
    bool ContainsBlock(GameObject b)
    {


        for (int j = 0; j < cols.Length; j++)
        {
            if (cols[j].gameObject == b)
            {

                return true;
            }
        }

        return false;
    }
}