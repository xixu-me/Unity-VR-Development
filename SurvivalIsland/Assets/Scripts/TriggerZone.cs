using UnityEngine;
using System.Collections;

public class TriggerZone : MonoBehaviour
{
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			transform.FindChild("door").SendMessage("DoorCheck");
		}
	}
}
