using UnityEngine;
using System.Collections;

public class OnButton : MonoBehaviour {

	public GameObject obstacle;
	public bool buttonPressed = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") {
			this.GetComponent<Animator>().Play("b1");
			obstacle.GetComponent<Animator>().Play("obstacle down");
			//buttonPressed = true;
		}
	}
	void StopAnim()
	{
		animation.Stop ();

	}
}
