using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public float dogSpawnCooldown = 1.0f;

    public float dogSpawnTimeCount;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && dogSpawnTimeCount > dogSpawnCooldown * 60 * (1 - Time.deltaTime))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            dogSpawnTimeCount = 0;
        }

        dogSpawnTimeCount++;
    }
}
