using UnityEngine;
using System.Collections;

public class BallArc : MonoBehaviour {
	
	public float speed = 2f;
	public float height = 2f;
	public float distance = -2f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//Ball bounces on Y axis in a sine wave
		transform.position += new Vector3 (distance, Mathf.Sin(Time.time * speed), 0f) * Time.deltaTime * height;
	}
}
