using UnityEngine;
using System.Collections;

public class spawnScript : MonoBehaviour {

	//audio
	public AudioClip jellyKidSound;
	private AudioSource source;
	public float vol;

	//Core ingredients
	public GameObject bread;
	public GameObject jelly;
	public GameObject peanut;
	public GameObject butter;
	//other ingredients
	public GameObject ingredient_1;
	public GameObject ingredient_2;
	public GameObject ingredient_3;
	public GameObject ingredient_4;
	public GameObject ingredient_5;

	//table
	public GameObject table;

	//spawn points above table. These game objects store the position.
	public GameObject spawnPoint1;
	public GameObject spawnPoint2;
	public GameObject spawnPoint3;
	public GameObject spawnPointBread;

	//array to store the positions
	private GameObject[] array;

	// Use this for initialization
	void Start () {

		//get audio source
		source = GetComponent<AudioSource>();

		//initialize the array and add the spawn points
		array = new GameObject[4];
		array [0] = spawnPoint1;
		array [1] = spawnPoint2;
		array [2] = spawnPoint3;
		array [3] = spawnPointBread;

	}

	// Update is called once per frame
	void Update () {

	}

	//spawn bread
	public void spawnBread(){
		//playsound
		source.PlayOneShot(jellyKidSound,vol);
		//choose a random number to choose a random spawn position above the table
		int randNum=Random.Range (0, 3);

		//if the bread gameobject exists and is not null, spawn.
		if (bread) {
			GameObject newBread = Instantiate (bread, array [3].transform.position, Quaternion.identity) as GameObject;
			newBread.transform.SetParent (table.transform);
		}
	}
	//spawn jelly
	public void spawnJelly(){
		//playsound
		source.PlayOneShot(jellyKidSound,vol);

		int randNum=Random.Range (0, 3);
		if (jelly) {
			GameObject newJelly =Instantiate (jelly, array [randNum].transform.position, Quaternion.identity) as GameObject;
			newJelly.transform.SetParent (table.transform);
		}
	}
	//spawnScript peanut butter
	public void spawnPeanutButter(){
		//playsound
		source.PlayOneShot(jellyKidSound,vol);

		int randNum=Random.Range (0, 3);
		if (peanut) {
			GameObject newPeanut =Instantiate (peanut, array [randNum].transform.position, Quaternion.identity) as GameObject;
			newPeanut.transform.SetParent (table.transform);
		}
		if (butter) {
			GameObject newButter =Instantiate (butter, array [randNum].transform.position, Quaternion.identity) as GameObject;
			newButter.transform.SetParent (table.transform);
		}
	}
	//Spawn other ingredients
	public void spawnIngredient1(){
		//playsound
		source.PlayOneShot(jellyKidSound,vol);

		int randNum=Random.Range (0, 3);
		if (ingredient_1) {
			GameObject newIngredient =Instantiate (ingredient_1, array [randNum].transform.position, Quaternion.identity) as GameObject;
			newIngredient.transform.SetParent (table.transform);
		}
	}
	public void spawnIngredient2(){
		//playsound
		source.PlayOneShot(jellyKidSound,vol);

		int randNum=Random.Range (0, 3);
		if (ingredient_2) {
			GameObject newIngredient =Instantiate (ingredient_2, array [randNum].transform.position, Quaternion.identity) as GameObject;
			newIngredient.transform.SetParent (table.transform);
		}
	}
	public void spawnIngredient3(){
		//playsound
		source.PlayOneShot(jellyKidSound,vol);

		int randNum=Random.Range (0, 3);
		if (ingredient_3) {
			GameObject newIngredient =Instantiate (ingredient_3, array [randNum].transform.position, Quaternion.identity) as GameObject;
			newIngredient.transform.SetParent (table.transform);
		}
	}
	public void spawnIngredient4(){
		//playsound
		source.PlayOneShot(jellyKidSound,vol);

		int randNum=Random.Range (0, 3);
		if (ingredient_4) {
			GameObject newIngredient =Instantiate (ingredient_4, array [randNum].transform.position, Quaternion.identity) as GameObject;
			newIngredient.transform.SetParent (table.transform);
		}
	}
	public void spawnIngredient5(){
		//playsound
		source.PlayOneShot(jellyKidSound,vol);

		int randNum=Random.Range (0, 3);
		if (ingredient_5) {
			GameObject newIngredient =Instantiate (ingredient_5, array [randNum].transform.position, Quaternion.identity) as GameObject;
			newIngredient.transform.SetParent (table.transform);
		}
	}
	// reload the level to make another sandwitch
	public void makeAnotherSandwitch(){
		Application.LoadLevel(Application.loadedLevel);
	}
	//quite app
	public void quitApp(){
		Application.Quit ();
	}
}
