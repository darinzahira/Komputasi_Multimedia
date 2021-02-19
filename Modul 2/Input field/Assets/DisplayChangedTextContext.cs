using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayChangedTextContext : MonoBehaviour
{

    private InputField InputField;
    // Start is called before the first frame update
    void Start()
    {
        InputField = GetComponent<InputField>();
    }

    public void PrintNewValue()
    {
        string msg = "new content = ' " + InputField.text + " '";
        print(msg);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
