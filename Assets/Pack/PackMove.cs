using UnityEngine;
using System.Collections;

public class PackMove : MonoBehaviour {

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//テストコード
		if(Input.GetKey(KeyCode.Space)){
				Rigidbody rb = GetComponent<Rigidbody>();
				rb.AddForce(new Vector3(100,0,0),ForceMode.Acceleration);
		}
	
	}
}
