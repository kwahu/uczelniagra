using UnityEngine;
using System.Collections;

public class Grenade : MonoBehaviour {

	float live = 100;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		--live;
		if (live < 0)
			Destroy (this.gameObject);
	}
}
