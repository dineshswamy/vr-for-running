using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetSpeed : MonoBehaviour {

	// Use this for initialization
	public void getTreadmillSpeed () {
		GameObject inputFieldGo = GameObject.Find("InputField");
		InputField inputFieldCo = inputFieldGo.GetComponent<InputField>();
		PlayerPrefs.SetString("speed", inputFieldCo.text);
		//Application.LoadLevel ("Scene2");
		Debug.Log(inputFieldCo.text);
	}

}
