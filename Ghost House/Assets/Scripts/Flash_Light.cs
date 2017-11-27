using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Flash_Light : MonoBehaviour {

	public bool lightOn = true;

	public int maxPower = 4;

	public int currentPower;

	public Light light;

	// Use this for initialization
	void Start () {
		currentPower = maxPower;
		print("power = " + currentPower);

		light = GetComponent<Light>();
		//Set light default to on
		lightOn = true;
		light.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		//Toggle light on/off when L key is pressed.
		if (Input.GetKeyUp (KeyCode.F) && lightOn) {
			lightOn = false;
			light.enabled = false;
		}

		else if (Input.GetKeyUp (KeyCode.F) && !lightOn){
			lightOn = true;
			light.enabled = true;
		}
	
	}
	public void setLightOn(){
		lightOn = true;
	}
	public bool isLightOn(){
		return lightOn;

	}
}