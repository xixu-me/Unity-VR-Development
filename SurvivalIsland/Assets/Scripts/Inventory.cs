using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
	public static int charge = 0;
	public AudioClip collectSound;

	// Use this for initialization
	void Start () {
		charge = 0;
	}
	
	// Update is called once per frame
	void Update () {
		AudioSource.PlayClipAtPoint (collectSound, transform.position); charge++; 
	}
}
