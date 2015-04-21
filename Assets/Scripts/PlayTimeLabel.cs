using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class PlayTimeLabel : MonoBehaviour {
	private Text textLabel;

	void Awake(){
		textLabel = GetComponent<Text>();
	}


	// Update is called once per frame
	void Update () {
		textLabel.text = string.Format ("Twój czas: {0:0.00}", LevelMaster.Instance.PlayTime);
	}
}
