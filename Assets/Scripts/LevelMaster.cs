using UnityEngine;
using System;
using System.Collections;

public class LevelMaster : MonoBehaviour
{
	static public LevelMaster Instance {
		get{
			if(instance == null)
			{
				GameObject levelMasterObject = 
					new GameObject("Level Master", typeof(LevelMaster));
				instance = levelMasterObject.GetComponent<LevelMaster>();
			}

			return instance;
		}
	}

	static private LevelMaster instance;

	public float PlayTime {
		get {
			return playTime;
		}
	}

	public int Points {
		get {
			return points;
		}
	}

	public Action onLevelEnd;

	private LevelState levelState = LevelState.Unstarted;

	private float playTime = 0.0f;

	private int points = 0;


	public void EndLevel(){
		Debug.Log (string.Format("Koniec poziomu {0:0.00}.", playTime));
		levelState = LevelState.Ended;
		if (onLevelEnd != null) {
			onLevelEnd();
		}
	}

	public void StartLevel(){
		playTime = 0.0f;
		Debug.Log (string.Format("Początek poziomu {0:0.00}.", playTime));
		levelState = LevelState.Run;
	}

	public void AddPoints(int pointsToAdd){
		points += pointsToAdd;
	}


	// Use this for initialization
	void Awake ()
	{
		instance = this;
	}

	void Update(){
		switch(levelState){
		case LevelState.Run:
			playTime += Time.deltaTime;
			break;
		}
	}


	public enum LevelState{
		Unstarted, Run, Ended
	}
}

