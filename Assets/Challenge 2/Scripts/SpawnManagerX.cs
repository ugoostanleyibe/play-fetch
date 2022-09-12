using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX: MonoBehaviour
{
	public GameObject[] ballPrefabs;

	private readonly float spawnLimitXLeft = -22;
	private readonly float spawnLimitXRight = 7;
	private readonly float spawnPosY = 30;

	private readonly float startDelay = 1.0f;
	private readonly float minSpawnInterval = 3.0f;
	private readonly float maxSpawnInterval = 5.0f;

	// Start is called before the first frame update
	void Start()
	{
		Invoke(nameof(SpawnRandomBall), startDelay);
	}

	// Spawn random ball at random x position at top of play area
	void SpawnRandomBall()
	{
		// Generate random ball index and random spawn position
		Vector3 spawnPos = new(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
		int ballIndex = Random.Range(0, ballPrefabs.Length);

		// instantiate ball at random spawn location
		Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[0].transform.rotation);

		Invoke(nameof(SpawnRandomBall), Random.Range(minSpawnInterval, maxSpawnInterval));
	}
}
