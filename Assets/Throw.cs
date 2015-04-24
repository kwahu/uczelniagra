using UnityEngine;
using System.Collections;

public class Throw : MonoBehaviour {
	public GameObject granat;
	// Use this for initialization
	void Start () {
		granat.rigidbody.AddForce ((transform.forward + (Vector3.up * 0.5f))*10 , ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
