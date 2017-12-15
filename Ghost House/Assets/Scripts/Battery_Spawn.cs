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
	void Update () {
		if(battEx == false){
			StartCoroutine(spawnBat(spawnTime, battery));
		}
		else{
			print("Nada");
		}
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Battery"){
			battEx = true;
		}
		else{
			battEx = false;
		}
	}

	IEnumerator spawnBat(float time, Rigidbody bat){
		yield return new WaitForSeconds(time);
		Instantiate(battery, spawnPoint.position, spawnPoint.rotation);
		battEx = true;
		
	}
}
