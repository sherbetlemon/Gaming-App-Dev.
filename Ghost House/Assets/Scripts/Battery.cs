using UnityEngine;
using System.Collections;

public class Battery : MonoBehaviour {

	public int power = 4;

	public gameObject flashlight;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other){
		if(other.gameObject.tag == "Player"){
			flashlight.GameObject.GetComponentInChildren<Flash_Light>().currentPower = power;
			Destroy(gameObject);
		}
	}
}
