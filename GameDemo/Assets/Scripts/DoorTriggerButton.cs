using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerButton : MonoBehaviour
{
    [SerializeField] private GameObject doorGameObjectA;

    private IDoor doorA;

	private void Awake()
	{
		doorA = doorGameObjectA.GetComponent<IDoor>();
	}
	private void Update()
	{
        if (Input.GetKeyDown(KeyCode.R))
        {
            doorA.OpdenDoor();
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            doorA.CloseDoor();
        }
    }
}
