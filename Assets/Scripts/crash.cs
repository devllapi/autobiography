using UnityEngine;
using System.Collections;

public class crash : MonoBehaviour {
	public AudioSource myAudio; //assign in inspector

	// Use this for initialization

	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision col){
		//if the player collides with an employee, sound will play
		if(col.gameObject.tag=="employee"){
			myAudio.Play ();
			//but don't interrupt if already playing
			if (myAudio.isPlaying == false) {
				myAudio.Play ();
				//myAudio.PlayOneShot makes a different audiosource each time it is called upon, can create multiple instances of the same sound
				//myAudio.PlayOneShot(myAudio.clip);
			}
		}
}
}
//if(myAudio.isPlaying==false){
//myaudio.loop=true;
//audio.Play();
//else{
//	myAudio.loop=false;
//	myAudio.Stop();
//}

//audio arrays allow you to call upon random sound clips from a list that can be changed in the inspector
