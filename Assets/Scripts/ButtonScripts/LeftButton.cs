using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        PlayerMove.isTurningLeft = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        PlayerMove.isTurningLeft = false;
    }
}
