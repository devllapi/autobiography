using UnityEngine;
using System.Collections;

public class rushHour : MonoBehaviour {
	public GameObject employee1;
	public GameObject employee2;
	public float moveSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		employee1.transform.Translate (Mathf.Sin(Time.deltaTime), 0f, 0f);
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "wall") {
			employee1.transform.Translate (-moveSpeed * Time.deltaTime, 0f, 0f);
			Debug.Log ("ouch");
		} 
	}
}
