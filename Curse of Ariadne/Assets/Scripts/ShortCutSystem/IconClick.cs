using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class IconClick : MonoBehaviour, IPointerDownHandler
{
    public UnityEvent OnDoubleClick;
    private int curr_click = 0;
    float clicktime = 0;
    float clickdelay = 0.5f;

    public void OnPointerDown(PointerEventData eventData)
    {
        curr_click++;
        if (curr_click == 1)
            clicktime = Time.time;

        if (curr_click > 1 && Time.time - clicktime < clickdelay)
        {
            curr_click = 0;
            clicktime = 0;
            OnDoubleClick.Invoke();
        }
        else if (curr_click > 2 || Time.time - clicktime > clickdelay)
            curr_click = 0;
    }
}
