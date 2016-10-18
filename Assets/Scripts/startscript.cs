using UnityEngine;
using System.Collections;

public class startscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			Application.LoadLevel("donutzone");
		}
		if(Input.GetKeyDown(KeyCode.R)){
			Application.LoadLevel("startgame");
		}
	}
}
