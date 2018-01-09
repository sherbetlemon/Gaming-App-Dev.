using UnityEngine;
using System.Collections;

public class Battery_Spawn : MonoBehaviour {

	public Rigidbody battery;

	public float spawnTime;

	public Transform spawnPoint;

	public bool battEx;
	private bool spawning = false;

	// Use this for initialization
	void Start () {
		battEx = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		if(battEx == false){
			if(!spawning){
				spawning = !spawning;
				StartCoroutine(spawnBat(spawnTime, battery));
				print("Spawn box is empty");
			}
			
		}
		else if(battEx == true){
			print("Battery has spawnd!");
		}
		
	}

	void OnTriggerEnter(Collider other){
		print("Collision Detected");
		if(other.gameObject.tag == "Battery"){
			print("Battery is in trigger");
			battEx = true;
		}
		
		}
		void OnTriggerExit(Collider other){
			if(other.gameObject.tag == "Battery"){
				print("Spawner is Empty");
				battEx = false;
				
			}
		}
	

	IEnumerator spawnBat(float time, Rigidbody bat){
		yield return new WaitForSeconds(time);
		Instantiate(battery, spawnPoint.position, spawnPoint.rotation);
		battEx = true;
		spawning = !spawning;
	}
	public void BatteryPickup(){

		print("Spawner is Empty");
		battEx = false;
	}

}