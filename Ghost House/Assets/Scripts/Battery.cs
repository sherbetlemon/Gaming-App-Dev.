using UnityEngine;
using System.Collections;

public class Battery : MonoBehaviour {

	public int power = 4;

	public GameObject flashlight;

	GameObject player;

	int checkBat;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");

		flashlight = player;
		//checkBat = flashlight.gameObject.GetComponentInChildren<Flash_Light>().currentPower;
		print("CkBat = " + checkBat);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other){
		if(other.gameObject.tag == "Player" && flashlight.gameObject.GetComponentInChildren<Flash_Light>().currentPower == 0){
			flashlight.gameObject.GetComponentInChildren<Flash_Light>().currentPower = power;
			Destroy(gameObject);
		}
	}
}
