using UnityEngine;
using System.Collections;
using System;

public class ExplorerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		String speedStr = PlayerPrefs.GetString("speed");
		int speed = System.Int32.Parse (speedStr);
		Vector3 input = new Vector3 (0, 0, 1);
		Vector3 direction = input.normalized;
		Vector3 velocity = direction * speed;
		Vector3 moveAmount = velocity * Time.deltaTime;
		transform.position += moveAmount;
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("You are going to be reset");
		Vector3 resetposition = new Vector3 (230, 11, 10.9f);
		transform.position = resetposition;
	}
}
