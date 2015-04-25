using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

	public string name;
	
	public void  ChangeScene()
	{
		Application.LoadLevel (name);
	}
}
