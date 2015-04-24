using UnityEngine;
using System.Collections;

public class ThrowGrenade : MonoBehaviour {
	// Use this for initialization
	public GameObject grenade;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp("left ctrl")){
			GameObject obj = (GameObject)Instantiate(grenade,this.transform.position,Quaternion.identity);
			obj.rigidbody.AddForce ((transform.forward + (Vector3.up * 0.7f))*10 , ForceMode.Impulse);
		}
	
	}
}
