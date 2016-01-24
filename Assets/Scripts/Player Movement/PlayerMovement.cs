using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("w")) {
			Debug.Log ("Pressing W Key");
		}

		if (Input.GetKey ("s")) {
			Debug.Log ("Pressing S Key");
		}

		if (Input.GetKey ("a")) {
			Debug.Log ("Pressing A Key");
		}

		if (Input.GetKey ("d")) {
			Debug.Log ("Pressing D Key");
		}

		if (Input.GetMouseButton (0)) {
			Debug.Log ("Mouse button 1");
		}

		if (Input.GetMouseButton (1)) {
			Debug.Log ("Mouse button 2");
		}
	}
}
