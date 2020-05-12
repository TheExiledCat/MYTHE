using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPuzzle : MonoBehaviour
{
    [SerializeField]
    GameObject[] blocks;
    Collider[] cols;
    // Start is called before the first frame update
    [SerializeField]
    Vector3 origin, extents;
    [SerializeField]
    Gate gate;
    int numberOfBlocks=0;
    [SerializeField]
    Pickup p;
    // Update is called once per frame
    void Update()
    {
        numberOfBlocks = 0;
        cols = Physics.OverlapBox(origin, extents, Quaternion.identity, Constants.SELECTABLE_LAYER);
        foreach(GameObject g in blocks)
        {
            if (ContainsBlock(g))
            {
                numberOfBlocks++;

            }
        }
        if (numberOfBlocks == blocks.Length&&p.selected==null)
        {
            Finish();
            enabled = false;
        }
        
    }
    void Finish()
    {
        foreach(GameObject g in blocks) {
            g.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
            g.GetComponent<Rigidbody>().freezeRotation = true;
            g.GetComponent<Selectable>().enabled = false;
        }
        gate.Open();
    }
    void OnDrawGizmos()
    {
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawWireCube(origin, extents);
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
