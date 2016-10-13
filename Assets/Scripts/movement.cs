using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	public float moveSpeed;
	Rigidbody rbody;

	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float inputX = Input.GetAxis ("Horizontal");
		float inputY = Input.GetAxis ("Vertical");

		rbody.AddForce(transform.forward * inputY * moveSpeed +
			transform.right * inputX * moveSpeed);
	}
}
