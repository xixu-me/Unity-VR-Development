using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Bullet: Start");
		Destroy (this.gameObject, 3f);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
