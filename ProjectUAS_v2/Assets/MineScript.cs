using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineScript : MonoBehaviour
{
    public GameHandlerMine GHM;

    // Start is called before the first frame update
    void Start()
    {
        GHM = GameObject.Find("Canvas").GetComponent<GameHandlerMine>();
    }

    // Update is called once per frame
    void Update()
    {

    } 

    private void OnTriggerEnter(Collider other)
    {
        GHM.status = "Game Over";
        Destroy(gameObject);
    }
}
