using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private PlayerInventoryDisplay playerInventoryDisplay;
    public Text candleText;
    private int totalCandles = 0;

    void Start()
    {
        UpdateCandleText();
        playerInventoryDisplay = GetComponent < PlayerInventoryDisplay > ();
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("lilin"))
        {
            totalCandles++;
            UpdateCandleText();
            playerInventoryDisplay.OnChangeCandleTotal(totalCandles);
            Destroy(hit.gameObject);
        }
    }

    private void UpdateCandleText()
    {
        string candleMessage = "Candles = " + totalCandles;
        candleText.text = candleMessage;
    }
}
