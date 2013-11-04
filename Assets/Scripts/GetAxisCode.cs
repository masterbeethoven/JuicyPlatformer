using UnityEngine;
using System.Collections;

public class GetAxisCode : MonoBehaviour {
	
		Vector3 inputVector;
		float speed = 40f;
		float move;
		public AudioClip impact;
        public float jumpForce;
		public float turnSpeed;
    
        bool fall = true;
        
	
	
	
        void Start () {
        
        }
        
        void Update () {
                Vector3 horizontalSpeed = Vector3.Scale(rigidbody.velocity, new Vector3(1f,0f,1f));
                
                Ray groundTest = new Ray(transform.position, -transform.up);
                RaycastHit groundTouch;
                bool grounded;
                
                grounded = Physics.Raycast(groundTest, out groundTouch, (collider.transform.localScale.y / 2f) + .5f);
                
                if (Input.GetKey(KeyCode.A))
                        transform.Rotate(Vector3.up, -turnSpeed);
		
                if (Input.GetKey(KeyCode.D)) 
                        transform.Rotate(Vector3.up, turnSpeed);
		
				if(Input.GetAxis("Vertical") !=0)
				{
					move = Input.GetAxis("Vertical") * speed *Time.deltaTime;
					transform.Translate(0,0, move);
				}
                
                if (Input.GetKeyDown(KeyCode.Space) && grounded) {
                        rigidbody.velocity.Scale(new Vector3(1f, 0f, 1f));
                        rigidbody.AddForce(transform.up * jumpForce, ForceMode.Acceleration);
                        grounded = fall = false;
                      
                }
           
        }
	
	void OnCollisionEnter(){
	
		audio.PlayOneShot(impact, 10f);
	}
	
	void OnTriggerEnter() {
		transform.position = new Vector3 (11f, 31f, -9f);
		
	}
	
}