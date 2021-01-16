using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Prefabs
    public GameObject foodProjectile;

    // Numeric Values
    public float boundaryX = 13.0f;
    public float speed = 10.0f;
    private float horizontalInput;

    private void Update()
    {
        ClampPosition();
        
        horizontalInput = Input.GetAxis("Horizontal");
        Vector3 translation = Vector3.right * Time.deltaTime * horizontalInput * speed;
        transform.Translate(translation);
    
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodProjectile, transform.position, foodProjectile.transform.rotation);
        }
    }


    /// <summary>
    /// This will create a buggy clamping whihc creates a desired effect
    /// </summary>
    private void ClampPosition()
    {
        if (transform.position.x < -boundaryX)
        {
            transform.position = new Vector3(-boundaryX, transform.position.y, transform.position.z);
        }
        if (transform.position.x > boundaryX)
        {
            transform.position = new Vector3(boundaryX, transform.position.y, transform.position.z);
        }
    }
}
