using UnityEngine;
using System.Collections;

public class OnButton : MonoBehaviour {

	public GameObject obstacle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") {
			this.GetComponent<Animator>().Play("button press anim");
			obstacle.GetComponent<Animator>().Play("obstacle clear");
		}
	}
	void StopAnim()
	{
		animation.Stop ();

	}
}
