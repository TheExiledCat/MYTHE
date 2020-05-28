using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeScaleUI : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float speed = 2;
    public Vector3 newScale;
    public bool changeScale = false;
    public Vector3 oldScale;

    void Start()
    {

        oldScale = transform.localScale;
    }

    void Update()
    {
        if(changeScale == true)
            transform.localScale = Vector3.Lerp(transform.localScale, newScale, speed * Time.unscaledDeltaTime);
        else
            transform.localScale = Vector3.Lerp(transform.localScale, oldScale, speed * Time.unscaledDeltaTime);

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        changeScale = true;
        Debug.Log("The cursor entered the selectable UI element.");

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        changeScale = false;
    }
}
