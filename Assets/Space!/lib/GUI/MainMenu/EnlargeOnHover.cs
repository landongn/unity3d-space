using UnityEngine;
using System.Collections;

public class EnlargeOnHover : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseEnter () {
       gameObject.guiText.fontSize = 125;
    }
	
	void OnMouseExit() {
		gameObject.guiText.fontSize = 110;
	}
	
}
