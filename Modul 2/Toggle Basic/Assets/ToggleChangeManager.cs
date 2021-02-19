using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleChangeManager : MonoBehaviour
{
    // Start is called before the first frame update
    private Toggle toggle;
    void Start()
    {
        toggle = GetComponent<Toggle>();
    }
    public void PrintNewToggleValue()
    {
        bool status = toggle.isOn;
        print("toggle status = " + status);
    }
}
