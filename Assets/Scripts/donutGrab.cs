using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class donutGrab : MonoBehaviour {

	public string[] donutNonsense;//assigns a variable to an array of strings
	public string[] currentDonutString;
	 float donutCount=0f;

	public Text gameText;//uses the text found inside the canvas
	public Text donutText;
	public Text currentDonutText;
	public Text reaction;

	public int currentDemand;
	public int currentDonut;

	public bool atCounter=false; 
	bool newInstruction=false;

	// Use this for initialization
	void Start () {
		currentDemand = Random.Range (0, donutNonsense.Length);
		gameText.text = donutNonsense [currentDemand];
		currentDonut = 3;
		atCounter = false;

	}
	
	// Update is called once per frame
	void Update () {
		donutText.text = donutCount.ToString();
		currentDonutText.text =currentDonutString[currentDonut];

	

		if (atCounter == false&&newInstruction==true) {
			reaction.text = "";
			if (donutCount > 0) {
				//currentDemand = Random.Range (0, donutNonsense.Length);
				gameText.text = donutNonsense [currentDemand];
				currentDonut = 3;
				newInstruction=false;
			}
			if(donutCount==6){
				Application.LoadLevel ("endgame");
			}
		}
		if (donutCount == 6) {
			gameText.text = "Took you long enough...";

		}
		if(atCounter==true&&Input.GetKeyDown(KeyCode.Space)){
			if(currentDemand==currentDonut){
				donutCount+=1;
				currentDemand = Random.Range (0, donutNonsense.Length);
				reaction.text="Thanks, I guess.";
			}
			else if(currentDemand!=currentDonut){
				donutCount-=1f;
				reaction.text = "Thats not what I asked for. Are you new here?";
			
		}
			if (donutCount < 0) {
				donutCount = 0;
			}
					}
					}

	void OnCollisionExit(Collision col2){
		if (col2.gameObject.tag == "counter") {
			atCounter = false;
			newInstruction = true;
		}
	}

		
	void OnCollisionStay(Collision col){
		if(col.gameObject.tag=="brown" && Input.GetKeyDown(KeyCode.Space)){

			currentDonut=0;

		}
		if(col.gameObject.tag=="pink" && Input.GetKeyDown(KeyCode.Space)){
	
			currentDonut=1;

		}
		if (col.gameObject.tag=="blue" && Input.GetKeyDown(KeyCode.Space)){

			currentDonut=2;

		}

		if (col.gameObject.tag=="counter"){ 
			atCounter = true;
			Debug.Log ("counter");
	}	
			}
}

