using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	public float moveSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float inputX = Input.GetAxis ("Horizontal");
		float inputY = Input.GetAxis ("Vertical");

		transform.Translate (inputX*moveSpeed*Time.deltaTime, 0f, 0f);
		transform.Translate (0f, 0f, inputY * moveSpeed * Time.deltaTime);
	}
}
