using UnityEngine;
using System.Collections;

public class NiszczenieSciany : MonoBehaviour {
	public GameObject wybuch;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other ){

		if (other.tag == "Player") {
			Debug.Log("WykrywaKolizje");
			this.gameObject.SetActive(false);
			wybuch.SetActive(true);
		}
	}
}
