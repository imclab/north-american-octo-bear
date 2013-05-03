using UnityEngine;
using System.Collections;

public class GolfSwing : MonoBehaviour {
	
	public float swing;
	// Use this for initialization
	void Start () {
		float swing = transform.rotation.eulerAngles.z;
	}
	
	// Update is called once per frame
	void Update () {
		//Rotate the Z Axis by -50 degrees every second
		if (swing == 238f) {
			swing = 238f;
		} else {
			transform.Rotate(new Vector3 (0f, 0f, -150f) * Time.deltaTime);
		}
	}
}
