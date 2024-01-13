using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RevButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        PlayerMove.isReversing = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        PlayerMove.isReversing = false;
    }
}

