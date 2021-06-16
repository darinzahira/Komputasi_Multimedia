using UnityEngine;
using System.Collections; 
public class RotateLight : MonoBehaviour
{
    public float speed = -0.5f;
    void Update()
    {
        // transform.Rotate(Vector3.up * speed * Time.deltaTime);
        transform.Rotate(new Vector3(0, 1.0f, 0) * speed * Time.deltaTime);
    }
}
