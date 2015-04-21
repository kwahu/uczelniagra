using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

public class CoinPickup : MonoBehaviour {
	[SerializeField]
	private Type type = Type.Start;

	[SerializeField]
	private int pointsValue = 10;


	void Awake() {
		if(type != Type.Start)
		{
			gameObject.SetActive(false);
		}
	}


	void OnTriggerEnter(Collider other){
		if (other.tag == "Player" || other.transform.root.tag == "Player") {
			LevelMaster.Instance.AddPoints(pointsValue);

			if(type == Type.End){
				SendLevelMessage();
			}
			else if(type == Type.Start)
			{
				LevelMaster.Instance.StartLevel();
			}
		}
	}

	void SendLevelMessage ()
	{
		LevelMaster.Instance.EndLevel ();
	}


	public enum Type{
		Start, Checkpoint, End
	}
}
