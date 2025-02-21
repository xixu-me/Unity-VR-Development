using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	public Rigidbody bullet;
	public float power = 1500f;
	public float moveSpeed = 2f;

	// Use this for initialization
	void Start () {
		Debug.Log ("Shooter: Start");
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Horizontal") * Time.deltaTime * moveSpeed;
		float v = Input.GetAxis ("Vertical") * Time.deltaTime * moveSpeed;

		this.transform.Translate (h, v, 0);

		if (Input.GetButtonUp ("Fire1")) {
			Rigidbody instance = Instantiate (bullet,
			                                  this.transform.position,
			                                  this.transform.rotation) as Rigidbody;
			Vector3 forward = this.transform.TransformDirection(
				Vector3.forward);
			instance.AddForce (forward * power);
		}
	}
}
