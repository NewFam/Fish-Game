using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float speed = 1;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
		}
	void Move () {
		if (Input.GetKey (KeyCode.UpArrow)){
			transform.position += new Vector3 (0, speed * Time.deltaTime, 0);}
		else if (Input.GetKey (KeyCode.DownArrow)){
			transform.position += new Vector3 (0, -speed * Time.deltaTime, 0);}
		else if (Input.GetKey (KeyCode.RightArrow)){
			transform.position += new Vector3 (speed * Time.deltaTime, 0, 0);}
		else if (Input.GetKey (KeyCode.LeftArrow)){
			transform.position += new Vector3 (-speed * Time.deltaTime, 0, 0);}
		if (Input.GetKey (KeyCode.LeftArrow) && Input.GetKey (KeyCode.UpArrow)){
			transform.position += new Vector3 (-speed * Time.deltaTime, speed * Time.deltaTime, 0);}
		else if (Input.GetKey (KeyCode.RightArrow) && Input.GetKey (KeyCode.DownArrow)){
			transform.position += new Vector3 (speed * Time.deltaTime, -speed * Time.deltaTime, 0);}
		else if (Input.GetKey (KeyCode.RightArrow) && Input.GetKey (KeyCode.UpArrow)){
			transform.position += new Vector3 (speed * Time.deltaTime, speed * Time.deltaTime, 0);}
		else if (Input.GetKey (KeyCode.LeftArrow) && Input.GetKey (KeyCode.DownArrow)){
			transform.position += new Vector3 (-speed * Time.deltaTime, -speed * Time.deltaTime, 0);}
	}
}

