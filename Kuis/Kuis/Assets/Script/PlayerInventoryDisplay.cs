using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour
{
    public Image[] candlePlaceholders;

    public Sprite iconCandle;

    public Sprite iconCandleGrey;

    public void OnChangeCandleTotal(int candleTotal)
    {
        for (int i = 0; i < candlePlaceholders.Length; ++i)
        {
            if (i < candleTotal)
                candlePlaceholders[i].sprite = iconCandle;
            else
                candlePlaceholders[i].sprite = iconCandleGrey;
        }
    }
}
