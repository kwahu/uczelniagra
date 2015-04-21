using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class EndTextController : MonoBehaviour {
	private Text textLabel;
	
	void Awake(){
		textLabel = GetComponent<Text>();
		textLabel.enabled = false;
		LevelMaster.Instance.onLevelEnd += ShowEndLevelPopup;
	}

	void ShowEndLevelPopup(){
		textLabel.enabled = true;
	}
}
