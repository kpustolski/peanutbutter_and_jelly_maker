using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class RotateCamera : MonoBehaviour {

	public float speed;
	public Text hint;
	private bool showHint;
	// Use this for initialization
	void Start () {
		showHint = true;
	}
	
	// Update is called once per frame
	void Update () {
		//rotate counter clockwise if D is held down
		if (Input.GetKey (KeyCode.D)) {
			transform.RotateAround (Vector3.zero, Vector3.up, speed * Time.deltaTime);
			showHint = false;
		}
		//rotate clockwise if A is held down
		if (Input.GetKey (KeyCode.A)) {
			transform.RotateAround (Vector3.zero, Vector3.down, speed * Time.deltaTime);
			showHint = false;
		}
		//turn off hint text if showHint is set to false. We don't need it anymore.
		if (!showHint) {
			hint.enabled = false;
		}

	}

}
