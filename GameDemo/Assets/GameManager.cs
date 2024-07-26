using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	[SerializeField] private GameObject _startingSceneTransition;
	[SerializeField] private GameObject _endingSceneTransition;

	// Start is called before the first frame update
	void Start()
	{
		_startingSceneTransition.SetActive(true);
		Invoke("DisableStartingSceneTransition", 5f); // 5 saniye sonra fonksiyonu çaðýr
	}

	// Update is called once per frame
	void Update()
	{

	}

	private void DisableStartingSceneTransition()
	{
		_startingSceneTransition.SetActive(false);
	}
}
