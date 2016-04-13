using UnityEngine;
using System.Collections;

public class FlattenScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "toast") {
			gameObject.transform.localScale = new Vector3(1f, 0.2f, 1f);

		}
	}
}
