using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WindowMove : MonoBehaviour, IDragHandler, IPointerDownHandler
{
    private RectTransform dragable;
    private Canvas canvas;

    public void Awake()
    {
        dragable = transform.parent.GetComponent<RectTransform>();
        canvas = GameObject.FindGameObjectWithTag("Canvas").GetComponent<Canvas>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        dragable.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        dragable.SetAsLastSibling();
    }
}
