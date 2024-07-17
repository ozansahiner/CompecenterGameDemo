using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kapi : MonoBehaviour
{
	public Animator animator; // Kapýyý açmak ve kapatmak için Animator bileþenini kullanacaðýz
	private bool isOpen = true; // Kapýnýn açýk olup olmadýðýný kontrol etmek için

	void Start()
	{
		// Animator bileþenini al
		animator = GetComponent<Animator>();
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.E))
		{
			if (isOpen)
			{
				Debug.Log("Kapi kapaniyor");
				CloseDoor();
			}
			else
			{
				Debug.Log("Kapi aciliyor");
				OpenDoor();
			}
		}
	}

	void OpenDoor()
	{
		animator.SetBool("isOpen", true); // Animator'da "isOpen" parametresini true yaparak kapýyý aç
		isOpen = true;
		Debug.Log("isOpen parametresi true yapildi");
	}

	void CloseDoor()
	{
		animator.SetBool("isOpen", false); // Animator'da "isOpen" parametresini false yaparak kapýyý kapat
		isOpen = false;
		Debug.Log("isOpen parametresi false yapildi");
	}
}