using UnityEngine;
using System.Collections;

public class LookAround : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		transform.LookAt(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
	}
}
