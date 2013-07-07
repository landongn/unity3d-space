using UnityEngine;
using System.Collections;

public class StaticEntity : MonoBehaviour {
	
	private static StaticEntity _instance;
	
	void Awake() {
		if (_instance != null) {
			_instance = this;
			DontDestroyOnLoad(this);
		}
		
	}
	
	// Use this for initialization
	void Start () {
		if (_instance) {
			Destroy (this);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	//OnMouseEnter is called when the mouse entered the GUIElement or Collider.
	void OnMouseEnter () {}
	
	//OnMouseOver is called every frame while the mouse is over the GUIElement or Collider.
	void OnMouseOver () {}
	
	//OnMouseExit is called when the mouse is not any longer over the GUIElement or Collider.
	void OnMouseExit () {}
	
	//OnMouseDown is called when the user has pressed the mouse button while over the GUIElement or Collider.
	void OnMouseDown () {}
	
	//OnMouseUp is called when the user has released the mouse button.
	void OnMouseUp () {}
	
	//OnMouseUpAsButton is only called when the mouse is released over the same GUIElement or Collider as it was pressed.
	void OnMouseUpAsButton () {}
	
	//OnMouseDrag is called when the user has clicked on a GUIElement or Collider and is still holding down the mouse.
	void OnMouseDrag () {}
	
	//called when the another collider enters this objects trigger 
	void OnTriggerEnter () {}
	void OnTriggerExit () {}
	void OnTriggerStay () {}
	
	//called when this objects coll/rigidbody has began touching another coll/rigid
	void OnCollisionEnter () {}
	
	//called when another entity has ceased touching
	void OnCollisonExit () {}
	
	//called when continous collision is happening
	void OnCollisionStay () {}
	
	void OnEnable () {}
	void OnDisable () {}
	void OnDestroy () {}
	
}