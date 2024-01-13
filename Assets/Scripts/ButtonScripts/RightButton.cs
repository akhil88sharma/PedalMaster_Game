using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RightButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        PlayerMove.isTurningRight = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        PlayerMove.isTurningRight = false;
    }
}
