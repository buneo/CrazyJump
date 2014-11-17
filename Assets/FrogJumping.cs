using UnityEngine;
using System.Collections;

public class FrogJumping : MonoBehaviour {
	Vector3 velocity = Vector3.zero;
	public int count;
	public Vector3 jumpVel; 
	public Vector3 gravity;
	public float speed = 2500;
	public float forwardSpeed = 200;
	bool didJump = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
				forwardSpeed += Time.deltaTime*speed;
		}
		if(Input.GetKeyUp(KeyCode.Space))
		{
			didJump =true; 

		}
	}
	void FixedUpdate ()
	{
		if (didJump) {
			rigidbody2D.AddForce(Vector2.right*forwardSpeed);
			rigidbody2D.AddForce(Vector2.up*forwardSpeed*2);
			didJump = false;
			forwardSpeed =60;
				}
		}
}