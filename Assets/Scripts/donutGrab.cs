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


	public int currentDemand;
	public int currentDonut;

	bool atCounter=false; 

	// Use this for initialization
	void Start () {
		currentDemand = Random.Range (0, donutNonsense.Length);
		gameText.text = donutNonsense [currentDemand];
		currentDonut = 3;

	}
	
	// Update is called once per frame
	void Update () {
		donutText.text = donutCount.ToString();
		currentDonutText.text =currentDonutString[currentDonut];

		if (donutCount == 12) {
			gameText.text = "Took you long enough...";

		}
		if(atCounter=true&&Input.GetKeyDown(KeyCode.Space)){
			if(currentDemand==currentDonut){
				donutCount+=1;
				currentDemand = Random.Range (0, donutNonsense.Length);
				gameText.text="Thanks, I guess.";
			}
			else if(currentDemand!=currentDonut){
				donutCount-=1f;
				gameText.text = "That's not what I asked for. Are you new here?";
		}
					}
					}
	void OnCollisionExit(Collision col2){
		if (col2.gameObject.tag == "counter" && currentDemand==currentDonut) {
			if (donutCount > 0) {
				currentDemand = Random.Range (0, donutNonsense.Length);
				gameText.text = donutNonsense [currentDemand];
				currentDonut = 3;
			}
			if(col2.gameObject.tag=="counter" && donutCount==12){
				Application.LoadLevel ("endgame");
			}
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
	}	
			}
}

