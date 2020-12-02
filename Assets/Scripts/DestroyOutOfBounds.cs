using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;

    void Update()
    {
        //Destroy if go above screen
        if (transform.position.z > topBound) Destroy(gameObject);

        //If go below screen, destroy and end game
        if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
