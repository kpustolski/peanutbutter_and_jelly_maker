using UnityEngine;
using System.Collections;

public class ballDropScript : MonoBehaviour {

	public GameObject sphere;
	public GameObject cube;

	public GameObject spawnPoint1;
	public GameObject spawnPoint2;
	public GameObject spawnPoint3;

	private GameObject[] array;

	// Use this for initialization
	void Start () {

//		array = new GameObject[3];
		array = new GameObject[3];
		array [0] = spawnPoint1;
		array [1] = spawnPoint2;
		array [2] = spawnPoint3;

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void spawnSphere(){
		
		int randNum=Random.Range (0, 3);
		Debug.Log (array[randNum]);
		if (sphere) {
			Instantiate (sphere, array [randNum].transform.position, Quaternion.identity);
		}
	}

	public void spawnCube(){
		int randNum=Random.Range (0, 3);
		Debug.Log (array[randNum]);
		if (cube) {
			Instantiate (cube, array [randNum].transform.position, Quaternion.identity);
		}
	}
}
