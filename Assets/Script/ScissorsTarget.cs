using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScissorsTarget : Droppable
{
    [SerializeField] GameObject beforeCutting;
    [SerializeField] GameObject afterCuttingA;
    [SerializeField] GameObject afterCuttingB;

    public override void OnDropSuitItem(DraggableItems item, GameObject obj)
    {
        if (item != DraggableItems.Scissors) return;

        beforeCutting.SetActive(false);
        afterCuttingA.SetActive(true);
        afterCuttingB.SetActive(true);
    }
}
