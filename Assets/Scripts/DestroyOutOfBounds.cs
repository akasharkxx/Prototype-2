using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float zDown = -5.0f;
    public float zUp = 30.0f;

    private void Update()
    {
        if (transform.position.z > zUp)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < zDown)
        {
            Destroy(gameObject);
        }
    }
}
