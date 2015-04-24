using UnityEngine;
using System.Collections;

public class NiszczenieSciany : MonoBehaviour {
	public GameObject explosion;
	public GameObject obstacle;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other ){

		Debug.Log ("trigger");

		if (other.tag == "Grenade") {
			Debug.Log ("Grenade");
			obstacle.SetActive(false);
			explosion.SetActive(true);
		}
	}
}
