using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    
    public float horizontalInput;

    public float speed = 20.0f;
    public float xRange = 10.0f;
    
    void Start()
    {
        
    }

    void Update()
    {
        //Move player left/right based on horizontal input
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //Keep player in bounds based on xRange variable
        if (transform.position.x > xRange) transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        if (transform.position.x < -xRange) transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        //If space is pressed, instantiate new projectile
        if (Input.GetKeyDown(KeyCode.Space)) Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
    }
}
