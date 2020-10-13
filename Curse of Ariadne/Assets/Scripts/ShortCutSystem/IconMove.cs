using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IconMove : MonoBehaviour, IDragHandler
{
    private RectTransform dragable;
    private Canvas canvas;

    public void Awake()
    {
        dragable = transform.GetComponent<RectTransform>();
        canvas = GameObject.FindGameObjectWithTag("Canvas").GetComponent<Canvas>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        dragable.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
}
