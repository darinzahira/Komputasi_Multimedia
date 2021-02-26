using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour
{
    public Text starText;

    public void OnChangeCarryingStar(bool carryingStar)
    {
        string starMessage = "Tidak Ambil Tulang :-(";
        if (carryingStar) starMessage = "Ambil Tulang :-)";
        starText.text = starMessage;
    }
}