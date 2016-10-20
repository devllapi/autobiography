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

		rbody.AddForce(new Vector3(0f,0f,moveSpeed * inputY) +
			new Vector3(inputX * moveSpeed,0f,0f ));
	}
}
