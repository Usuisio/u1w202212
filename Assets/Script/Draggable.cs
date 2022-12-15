using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class Draggable : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private Vector2 prevPos;
    private Vector3 screenToWorldPointPosition;

    public void OnBeginDrag(PointerEventData eventData)
    {
        // ドラッグ前の位置を記憶しておく
        prevPos = transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        // ドラッグ中は位置を更新する
        this.gameObject.transform.localPosition = GetLocalPosition();
    }

    private Vector3 GetLocalPosition()
    {
        Vector3 position = Input.mousePosition;
        position.z = -Camera.main.transform.position.z;
        return Camera.main.ScreenToWorldPoint(position);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // ドラッグ前の位置に戻す
        //transform.position = prevPos;
    }

    public abstract DraggableItems GetItemType();
}

public enum DraggableItems
{
    Scissors,
    Circle,
}