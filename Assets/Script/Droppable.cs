using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class Droppable : MonoBehaviour, IDropHandler
{
    [SerializeField]
    public void OnDrop(PointerEventData eventData)
    {
        var draggable = eventData.pointerDrag.gameObject.GetComponent<Draggable>();
        this.OnDropSuitItem(draggable.GetItemType(), eventData.pointerDrag.gameObject);
    }

    public abstract void OnDropSuitItem(DraggableItems item,GameObject obj);
    //その場でドラッグしてきたものを固定したいときとかに第二引数使う
}
