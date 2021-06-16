using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class DiamondScript : MonoBehaviour
{
    public GameHandlerDiamond GHD;
    public AudioClip diamoindSound;
    // Start is called before the first frame update
    void Start()
    {
        GHD = GameObject.Find("Canvas").GetComponent<GameHandlerDiamond>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        GHD.diamonds++;
        AudioSource.PlayClipAtPoint(diamoindSound, transform.position);
        Destroy(gameObject);
    }
}
