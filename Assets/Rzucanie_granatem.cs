using UnityEngine;
using System.Collections;

public class Rzucanie_granatem : MonoBehaviour {
	// Use this for initialization
	public GameObject granat;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp("left ctrl")){
			Instantiate(granat,this.transform.position,Quaternion.identity);
		}
	
	}
}
