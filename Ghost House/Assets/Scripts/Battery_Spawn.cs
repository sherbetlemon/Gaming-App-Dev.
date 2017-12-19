using UnityEngine;
using System.Collections;

public class Battery_Spawn : MonoBehaviour {

	public Rigidbody battery;

	public float spawnTime;

	public Transform spawnPoint;

	public bool battEx;

	// Use this for initialization
	void Start () {
		battEx = false;
	
	}
	
	// Update is called once per frame
	/*void Update () {
		if(battEx == false){
			//StartCoroutine(spawnBat(spawnTime, battery));
			print("Spawn box is empty");
		}
		else if(battEx == true){
			print("Battery has spawnd!");
		}
		
	}*/

	void OnTriggerStay(Collider other){
		print("Collision Detected");
		if(other.gameObject.tag == "Battery"){
			print("Battery is in trigger");
			battEx = true;
		}
		else if(other.gameObject == null){
			battEx = false;
			print("Spawn box is empty");
		}
	}

	/*IEnumerator spawnBat(float time, Rigidbody bat){
		yield return new WaitForSeconds(time);
		Instantiate(battery, spawnPoint.position, spawnPoint.rotation);
		battEx = true;
		
	}*/
}
