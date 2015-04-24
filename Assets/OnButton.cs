using UnityEngine;
using System.Collections;

public class OnButton : MonoBehaviour {

	public GameObject obstacle;
	public AnimationClip buttonanim;
	public AnimationClip obstacleanim;
	public bool Wcisniecieprzycisku=false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player"&& Wcisniecieprzycisku==false) {
			this.GetComponent<Animator>().Play("b1");
			obstacle.GetComponent<Animator>().Play("obstacle clear");
			Wcisniecieprzycisku=true;
		}
	}
	void StopAnim()
	{
		animation.Stop ();

	}
}
