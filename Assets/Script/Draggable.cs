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
        // �h���b�O�O�̈ʒu���L�����Ă���
        prevPos = transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        // �h���b�O���͈ʒu���X�V����
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
        // �h���b�O�O�̈ʒu�ɖ߂�
        //transform.position = prevPos;
    }

    public abstract DraggableItems GetItemType();
}

public enum DraggableItems
{
    Scissors,
    Circle,
}