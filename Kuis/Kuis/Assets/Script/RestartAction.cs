using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartAction : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

}
