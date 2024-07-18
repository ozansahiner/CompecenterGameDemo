using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject playerPrefab;

	void Start()
	{
		float x = PlayerPrefs.GetFloat("PlayerX", 0);
		float y = PlayerPrefs.GetFloat("PlayerY", 0);
		float z = PlayerPrefs.GetFloat("PlayerZ", 0);
		Vector3 spawnPosition = new Vector3(x, y, z);

		// Debug mesajý
		Debug.Log("Spawning player at position: " + spawnPosition);

		// Karakteri belirtilen konumda spawnla
		
	}
}