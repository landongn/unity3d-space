using UnityEngine;
using System.Collections;

public class ScaleUp : MonoBehaviour
{

	private Vector3 finalScale;
	private float currentScale;
	// Use this for initialization
	void Start ()
	{
		finalScale.x = 1;
		finalScale.y = 1;
		finalScale.z = 1;
		currentScale = transform.localScale.x;
	}

	// Update is called once per frame
	void Update ()
	{
		if (currentScale <= finalScale.x) {
			finalScale.x = (finalScale.x * (float)Time.deltaTime * 0.03f);
			finalScale.y = (finalScale.y * (float)Time.deltaTime * 0.03f);
			finalScale.z = (finalScale.z * (float)Time.deltaTime * 0.03f);
			transform.localScale = finalScale;
		}
	}
}

