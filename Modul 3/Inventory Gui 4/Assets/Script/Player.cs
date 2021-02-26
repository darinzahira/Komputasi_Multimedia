using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text starText;

    private int totalStars = 0;

    void Start()
    {
        UpdateStarText();
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Bone"))
        {
            totalStars++;
            UpdateStarText();
            Destroy(hit.gameObject);
        }
    }

    private void UpdateStarText()
    {
        string starMessage = "Bones = " + totalStars;
        starText.text = starMessage;
    }
}
