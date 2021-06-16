using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandlerDiamond : MonoBehaviour
{
    public Text CoinText;
    public int diamonds = 0;

    // Update is called once per frame
    void Update()
    {
        CoinText.text ="Diamond : " + diamonds;    
    }
} 
