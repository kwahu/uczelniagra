using UnityEngine;
using System.Collections;

public class Czasoumilacz : MonoBehaviour {

	public string mapa;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

			Application.LoadLevel(mapa);

	}
}
