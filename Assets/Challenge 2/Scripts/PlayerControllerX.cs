using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float keyPressInterval = 0.8f;

    private float elapsed = 0.0f;

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && elapsed >= keyPressInterval)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            elapsed = 0.0f;
        }
    }
}
