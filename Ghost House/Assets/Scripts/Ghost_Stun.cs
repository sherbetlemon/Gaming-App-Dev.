﻿using UnityEngine;
using System.Collections;

public class Ghost_Stun : MonoBehaviour {

	bool lightCheck;
	Flash_Light flash;
	public GameObject ghost;

	// Use this for initialization
	void Start () {
		flash = gameObject.GetComponentInChildren<Light>().GetComponentInChildren<Flash_Light>();
		// lightCheck = GetComponent<Flash_Light>().lightOn;
		print("Obj:" + flash);
		flash.setLightOn();
		print("Start" + flash.isLightOn());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		print(other.gameObject.name);
		print ("Collider" + flash);
		if(other.gameObject.name == "Ghost" && flash == true ){
			print("Ghost is stuned!");

			other.GetComponent<Ghost_AI>().moveSpeed = 0f;
			StartCoroutine(Wait(5, other));

		}
	}
	IEnumerator Wait(float time, Collider other){
		yield return new WaitForSeconds(time);
		other.gameObject.GetComponent<Ghost_AI>().moveSpeed = 3f;
			print("Ghost is unstunned");
	}
}
