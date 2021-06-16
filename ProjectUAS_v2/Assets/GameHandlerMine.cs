using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandlerMine : MonoBehaviour
{
    public Text StatusText;
    public string status = "";

    // Update is called once per frame
    void Update()
    {
        StatusText.text = status;
    }
}
 