using UnityEngine;
using System.Collections;

public class PlatformerAnimation : MonoBehaviour {
	
	public Rigidbody rigidbody; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Vertical") != 0f || Input.GetAxis("Horizontal") != 0f ){
			//animation["Animation"].speed = rigidbody.velocity.magnitude;
			animation.CrossFade("Walk");
		}
		
		else {
			
			animation.CrossFade ("Idle");
		}
	
		
	
	}
}
