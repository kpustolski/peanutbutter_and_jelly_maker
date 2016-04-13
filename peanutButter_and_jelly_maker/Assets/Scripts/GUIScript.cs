using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GUIScript : MonoBehaviour {

	//audio
	public AudioClip tadaSound;
	private AudioSource source;
	public float vol;

	//buttons
	public Button breadBtn;
	public Button jellyBtn;
	public Button peanutButterBtn;
	public Button nextBtn;
	public Button makeAnotherBtn;

	//table object
	public GameObject tableObj;

	// directions text
	public Text direction1;
	public Text direction2;
	public Text direction3;
	public Text direction4;
	public Text direction5;

	//locations
	private Vector3 hiddenLocation;
	private Vector3 centerLocation;
	private Vector3 otherLocation;
	private Vector3 nextBtnLocation;
//	private Vector3 multButtonLocation;
	//private Vector3 replayLocation;


	//booleons
	private bool breadBtnActive;
	private bool jellyBtnActive;
	private bool peanutButterBtnActive;
	//for the second time the bread button is active (step 4)
	private bool breadBtnActive2;
	private bool rotateTable;

	//speed for roatation
	public float speed;

	// Use this for initialization
	void Start () {

		//get audio source
		source = GetComponent<AudioSource>();

		//initialize locations
		// hiddenLocation will hide the buttons from the screen
		hiddenLocation = new Vector3 (383f,-200f,0f);

		// showLocation will make the buttons appear
		centerLocation = new Vector3 (Screen.width/2,Screen.height/7,0f);
		otherLocation = new Vector3 (Screen.width/2,Screen.height/7,0f);
		nextBtnLocation = new Vector3 (Screen.width-200,Screen.height/7,0f);

		// set the bread button active booleon to true since its active first.
		breadBtnActive = true;
		breadBtn.transform.position = centerLocation;
		// this bool is for step 4
		breadBtnActive2 = false;

		// hide and move all other buttons to the hidden location off screen
		jellyBtn.enabled = false;
		jellyBtn.transform.position= hiddenLocation;
		jellyBtnActive = false;

		peanutButterBtn.enabled = false;
		peanutButterBtn.transform.position= hiddenLocation;
		peanutButterBtnActive = false;

		makeAnotherBtn.enabled = false;
		makeAnotherBtn.transform.position= hiddenLocation;

		//disable directions except for direction1
		direction2.enabled = false;
		direction3.enabled = false;
		direction4.enabled = false;
		direction5.enabled = false;

		//set rotate table to false
		rotateTable = false;

		//next button location
		nextBtn.transform.position=nextBtnLocation;

	}
	
	// Update is called once per frame
	void Update () {
		//rotate the table at the end to show off masterpiece
		if (rotateTable) {
			tableObj.transform.Rotate (Vector3.up, speed * Time.deltaTime);
		}
	}

	public void changeState(){
		//if the bread button is active ie. step 1
		//move from step 1 to step 2
		if (breadBtnActive) {
			//turn off bread button
			breadBtnActive = false;
			breadBtn.enabled = false;
			direction1.enabled = false;
			breadBtn.transform.position= hiddenLocation;

			//turn on peanutbutter button
			peanutButterBtn.enabled = true;
			peanutButterBtnActive = true;
			direction2.enabled = true;
			peanutButterBtn.transform.position = centerLocation;
		//else if jelly button is active ie. step 2
		//move from step 2 to step 3
		} else if (peanutButterBtnActive) {
			//turn off jelly button
			peanutButterBtnActive = false;
			peanutButterBtn.enabled = false;
			direction2.enabled = false;
			peanutButterBtn.transform.position= hiddenLocation;

			//turn on peanutbutter button and other random buttons.
			jellyBtn.enabled = true;
			jellyBtnActive = true;
			direction3.enabled = true;
			jellyBtn.transform.position = otherLocation;
		//else if peanut butter button is active ie. step 3
		//move from step 3 to step 4
		}else if (jellyBtnActive) {
			//turn off peanutbutter button
			jellyBtnActive = false;
			jellyBtn.enabled = false;
			direction3.enabled = false;
			jellyBtn.transform.position= hiddenLocation;

			//turn on bread button and other random buttons.
			breadBtn.enabled = true;
			breadBtnActive2 = true;
			direction4.enabled = true;
			breadBtn.transform.position = centerLocation;
		}
		//else if bread button is active again (2nd time) ie. step 4
		//move from step 4 to step 5
		else if (breadBtnActive2) {
			breadBtnActive2 = false;
			breadBtn.enabled = false;
			direction4.enabled = false;
			breadBtn.transform.position= hiddenLocation;

			//Done!
			direction5.enabled = true;
			nextBtn.enabled = false;
			nextBtn.transform.position= hiddenLocation;
			rotateTable = true;
			//play tada! sound
			source.PlayOneShot(tadaSound,vol);

			//enable and show the reply button.
			makeAnotherBtn.enabled = true;
			makeAnotherBtn.transform.position = otherLocation;
		}

			
	}
}
