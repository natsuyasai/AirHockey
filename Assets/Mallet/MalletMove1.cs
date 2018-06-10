using UnityEngine;
using System.Collections;

public class MalletMove1 : MonoBehaviour {
	public Vector3 v3up;
	public Vector3 v3down;
	public Vector3 v3left;
	public Vector3 v3right;
	private Rigidbody rb;

	private GameObject gomallet;



	// Use this for initialization
	void Start () {
		gomallet = GameObject.FindWithTag("Mallet1");
		rb = GetComponent<Rigidbody>();
		v3up = new Vector3(-100,0,0);
		v3down = new Vector3(100,0,0);
		v3left = new Vector3(0,0,100);
		v3right = new Vector3(0,0,-100);
			
	}
	
	// Update is called once per frame
	void Update () {
		this.CheckPosition();
		if(Input.GetKey(KeyCode.UpArrow)){
				rb.AddForce(v3down,ForceMode.Acceleration);
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			rb.AddForce(v3up,ForceMode.Acceleration);
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			rb.AddForce(v3left,ForceMode.Acceleration);
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			rb.AddForce(v3right,ForceMode.Acceleration);
		}
	}

	void CheckPosition(){
		if(transform.position.x > 10){
			rb.velocity = Vector3.zero;
      rb.angularVelocity = Vector3.zero;
			transform.position = new Vector3(transform.position.x-0.1f,transform.position.y,transform.position.z);
		}
		else if(transform.position.x < 0.5f){
			rb.velocity = Vector3.zero;
      rb.angularVelocity = Vector3.zero;
			transform.position = new Vector3(transform.position.x+0.1f,transform.position.y,transform.position.z);
		}
	}
}
