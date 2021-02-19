using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrangeActions : MonoBehaviour
{
    private RectTransform panelRectTransform;

    void Start()
    {
        panelRectTransform = GetComponent<RectTransform>();
    }

    public void MoveDownOne()
    {
        print("(before change) " + gameObject.name + "sibling index = " + panelRectTransform.GetSiblingIndex());
        int currentSiblingIndex = 
        panelRectTransform.GetSiblingIndex();
        panelRectTransform.SetSiblingIndex(currentSiblingIndex - 1);
        print("(after change) " + gameObject.name + " sibling index = " + panelRectTransform.GetSiblingIndex());
    }

    public void MoveUpOne()
    {
        print("(before change) " + gameObject.name + "sibling index = " + panelRectTransform.GetSiblingIndex());
        int currentSiblingIndex = 
        panelRectTransform.GetSiblingIndex();
        panelRectTransform.SetSiblingIndex(currentSiblingIndex + 1);
        print("(after change) " + gameObject.name + " sibling index = " + panelRectTransform.GetSiblingIndex());
    }
}
