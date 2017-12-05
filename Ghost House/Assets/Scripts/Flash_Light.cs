using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Flash_Light : MonoBehaviour {

	public bool lightOn = true;

	public int maxPower = 4;

	public int currentPower;

	public int batDrainAmt;

	public float batDrainDelay;

	Light light;

	bool draining = false;

	long count = 0;

	public Text batteryText;

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
		if (Input.GetKeyUp (KeyCode.F) && lightOn){
			lightOn = false;
			light.enabled = false;
		}

		else if (Input.GetKeyUp (KeyCode.F) && !lightOn){
			lightOn = true;
			light.enabled = true;
		}

		batteryText.text = currentPower.ToString();

		if(currentPower > 0 && lightOn){
			if(!draining){
				StartCoroutine(BatteryDrain(batDrainDelay,batDrainAmt));
			}
			else if(currentPower <= 0){
				lightOn = false;
				light.enabled = false;
			}
		}
	
	}
	public void setLightOn(){
		lightOn = true;
	}
	public bool isLightOn(){
		return lightOn;

	}
	IEnumerator BatteryDrain(float delay, int amount){
		if(lightOn){
			draining = true;
			yield return new WaitForSeconds(delay);
			print(currentPower);
			currentPower -= amount;
		}
		if(currentPower <= 0){
			currentPower = 0;
			print("Battery is dead!");
			light.enabled = false;
		}
		draining = false;
	}
}