using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    [SerializeField]
    float maxRange;

    public GameObject selected;
    float dist;
 
    bool frame=false;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState=CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit,maxRange,Constants.SELECTABLE_LAYER)){
            if (hit.collider.GetComponent<Selectable>() != null&&Input.GetMouseButtonDown(0)&&selected==null)
            {
                selected = hit.collider.gameObject;
                dist = Vector3.Distance(Camera.main.transform.position, selected.transform.position);
                frame = true;
            }
        }
        print(frame);
        if (selected != null)
        {
            selected.GetComponent<Rigidbody>().freezeRotation = true;
            selected.transform.eulerAngles = Vector3.zero;
            selected.transform.position = Camera.main.transform.position+Camera.main.transform.forward*dist;
            if (Input.GetMouseButtonDown(0)&&!frame)
            {
                selected.GetComponent<Rigidbody>().freezeRotation = false;
                selected = null;
            }
            frame = false;
        }
        
            
        
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward*maxRange, Color.red);
        print(selected);
        
    }
    
}
