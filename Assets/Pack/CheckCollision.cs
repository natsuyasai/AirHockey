using UnityEngine;
using System.Collections;

public class CheckCollision : MonoBehaviour {

private Rigidbody rb;
private GameObject gopack;
	// Use this for initialization
	void Start () {
		gopack = GameObject.FindGameObjectWithTag("Pack");
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision cs){
		if(cs.gameObject.name == "Mallet1"){
				rb.AddForce(new Vector3(-1000,0,0),ForceMode.Acceleration);
		}
		if(cs.gameObject.name == "Mallet1"){
				rb.AddForce(new Vector3(1000,0,0),ForceMode.Acceleration);
		}
	}
	
	void OnCollisionExit(Collision cs){
		if(cs.gameObject.name == "Mallet1"){
				rb.AddForce(new Vector3(-1000,0,0),ForceMode.Acceleration);
		}
		if(cs.gameObject.name == "Mallet1"){
				rb.AddForce(new Vector3(1000,0,0),ForceMode.Acceleration);
		}	
	}
	void OnCollisionStay(Collision cs){
		if(cs.gameObject.name == "Mallet1"){
				rb.AddForce(new Vector3(-1000,0,0),ForceMode.Acceleration);
		}
		if(cs.gameObject.name == "Mallet1"){
				rb.AddForce(new Vector3(1000,0,0),ForceMode.Acceleration);
		}	
	}

}
