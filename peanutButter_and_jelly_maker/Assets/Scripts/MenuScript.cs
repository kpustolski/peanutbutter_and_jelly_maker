using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//quite app
	public void quitApp(){
		Application.Quit ();
	}

	public void beginExperience(){
		Application.LoadLevel("main");
	}
}
