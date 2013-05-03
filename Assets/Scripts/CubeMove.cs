using UnityEngine;
using System.Collections;

public class CubeMove : MonoBehaviour {
	
	//Labeling them "public" makes it appear in the Unity Editor
	public float speed = 2f;
	public float distance = 2f;
	
	// Use this for initialization
	void Start () {
		StartCoroutine( Movie() );
	
	}
	
	// Update is called once per frame
	void Update () {
		
//		//Move Cube 2 Units on the Y Axis every second!
//		//transform.position += new Vector3 (0f, 2f, 0f) * Time.deltaTime; 
//		
//		//Make the cube bounce according to a sine wave!
//		transform.position += new Vector3 (0f, Mathf.Sin(Time.time * speed), 0f) * Time.deltaTime * distance;
//		
//		//Rotate 1 degree on the Y Axis every second
//		transform.Rotate(new Vector3 (0f, 10f, 0f) * Time.deltaTime);
//		
//		//Move forward 5 units on the Z axis every second
//		transform.position += transform.forward * Time.deltaTime;
//		
//		//Print the value of Transform.forward
//		//Debug.Log (transform.forward);
//		
//		//Increase height of cube by 1 every second!
//		//transform.localScale = new Vector3 (transform.localScale.x, transform.localScale.y * 2f, transform.localScale.z);
	}
	
	IEnumerator Movie () {
		while(true) { 
			float timer = 0f;
			timer += Time.deltaTime; 
			
			if (timer > 1) {
				transform.position += transform.forward * Time.deltaTime;
				yield return new WaitForSeconds(0.0001f);
				timer = 0f;
			}
			
			
		}
	}
}
