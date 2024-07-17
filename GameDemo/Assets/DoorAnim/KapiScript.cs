using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kapi : MonoBehaviour
{
	public Animator animator; // Kap�y� a�mak ve kapatmak i�in Animator bile�enini kullanaca��z
	private bool isOpen = true; // Kap�n�n a��k olup olmad���n� kontrol etmek i�in

	void Start()
	{
		// Animator bile�enini al
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
		animator.SetBool("isOpen", true); // Animator'da "isOpen" parametresini true yaparak kap�y� a�
		isOpen = true;
		Debug.Log("isOpen parametresi true yapildi");
	}

	void CloseDoor()
	{
		animator.SetBool("isOpen", false); // Animator'da "isOpen" parametresini false yaparak kap�y� kapat
		isOpen = false;
		Debug.Log("isOpen parametresi false yapildi");
	}
}