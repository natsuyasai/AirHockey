using UnityEngine;
using System.Collections;

public class CheckPosion : MonoBehaviour {

private Rigidbody rb;
private GameObject gopack;
private const short Mallet1 = 1;
private const short Mallet2 = 2;
	// Use this for initialization
	void Start () {
		gopack = GameObject.FindGameObjectWithTag("Pack");
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Mallet1 == this.CheckPosition()){
			RespornPotison(5,0.4f,0);
		}
		else if(Mallet2 == this.CheckPosition()){
			RespornPotison(-5,0.4f,0);	
		}

	}

	short CheckPosition(){
		if(transform.position.x > 10){
			rb.velocity = Vector3.zero;
      rb.angularVelocity = Vector3.zero;
			return Mallet1;
		}
		else if(transform.position.x < -10){
			rb.velocity = Vector3.zero;
      rb.angularVelocity = Vector3.zero;
			return Mallet2;
		}
		return 0;
	}

	void RespornPotison(float x, float y, float z){
		transform.position = new Vector3(x,y,z);
	}



}
