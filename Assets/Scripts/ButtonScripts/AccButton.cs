using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AccButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        PlayerMove.isAccelrating = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        PlayerMove.isAccelrating = false;
    }
}

