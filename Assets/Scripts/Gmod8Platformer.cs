using UnityEngine;
using System.Collections;

public class Gmod8Platformer : MonoBehaviour {
	
	Vector3 jump = new Vector3 (0f, 20f, 0f); 
	Vector3 rightmove = new Vector3 (10f, 0f, 0f);
	Vector3 leftmove = new Vector3 (-10f, 0f, 0f);
	Vector3 upmove = new Vector3 (0f, 0f, 10f);
	Vector3 downmove = new Vector3 (0f, 0f, -10f);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space))
		{
			transform.position += jump *Time.deltaTime;
		}
		
		if (Input.GetKey(KeyCode.D))
		{
			transform.position += rightmove *Time.deltaTime;
		}
		
		if (Input.GetKey(KeyCode.A))
		{
			transform.position += leftmove *Time.deltaTime;
		}
		
		if (Input.GetKey(KeyCode.W))
		{
			transform.position += upmove *Time.deltaTime;
		}
		
		if (Input.GetKey(KeyCode.S))
		{
			transform.position += downmove *Time.deltaTime;
		}
			
	
	}
}
