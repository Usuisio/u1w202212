using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class Writer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickChoice(Choice choice)
    {
        _text.text = choice.GetString();
    }
}
