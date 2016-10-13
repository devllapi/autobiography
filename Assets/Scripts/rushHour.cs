using UnityEngine;
using System.Collections;

public class rushHour : MonoBehaviour {
	public GameObject employee1;
	public GameObject employee2;
	public float begin;
	public float end;
	public float moveSpeed;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		employee1.transform.position = new Vector3 (-6f + Mathf.PingPong (Time.time * moveSpeed, end), transform.position.y, transform.position.z);
		employee2.transform.position = new Vector3 (6f+Mathf.PingPong (Time.time*moveSpeed, end)*-1f, transform.position.y, -6f);
	}


	}

