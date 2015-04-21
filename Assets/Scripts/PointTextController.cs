using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class PointTextController : MonoBehaviour{
	private Text textLabel;

	void Awake(){
		textLabel = GetComponent<Text>();
	}

	void Update(){
		textLabel.text = string.Format ("Punkty: {0}", LevelMaster.Instance.Points);
	}
}

