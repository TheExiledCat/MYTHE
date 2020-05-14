using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPuzzle : MonoBehaviour
{
    [SerializeField]
    GameObject[] blocks;
    [SerializeField]
    Collider[] cols;
    // Start is called before the first frame update
    [SerializeField]
    Vector3 origin, extents;
    [SerializeField]
    Gate gate;
    int numberOfBlocks = 0;
    [SerializeField]
    Pickup p;

    // Update is called once per frame
    void Update()
    {
        numberOfBlocks = 0;
        cols = Physics.OverlapBox(transform.position, extents, Quaternion.identity,Constants.SELECTABLE_LAYER);
        foreach (GameObject g in blocks)
        {
            print(ContainsBlock(g));
            if (ContainsBlock(g))
            {
                numberOfBlocks++;

            }
        }
        print(numberOfBlocks);
        if (numberOfBlocks == blocks.Length && p.selected == null)
        {
            Finish();
            enabled = false;
        }

    }
    void Finish()
    {
        foreach (GameObject g in blocks)
        {
            
            g.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
            g.GetComponent<Rigidbody>().freezeRotation = true;
            g.GetComponent<Selectable>().enabled = false;
        }
        gate.Open();
    }
    void OnDrawGizmos()
    {
       // Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawWireCube(transform.position+origin, extents);
    }
    bool ContainsBlock(GameObject b)
    {


        for (int j = 0; j < cols.Length; j++)
        {
            if (cols[j] == b.GetComponent<BoxCollider>())
            {
                print(b);

                return true;
            }
        }

        return false;
    }
}