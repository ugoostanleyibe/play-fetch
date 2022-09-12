using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

	private readonly float spawnInterval = 1.0f;

    private float elapsed = 1.0f;

	// Update is called once per frame
	void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && elapsed >= spawnInterval)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            elapsed = 0.0f;
        }
        else
        {
            elapsed += Time.deltaTime;
        }
    }
}
