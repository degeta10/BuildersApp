using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelTranslate : MonoBehaviour {
	private Rigidbody rb;
	public GameObject model; 	
	Vector3 distance;
	float posx,posy;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();

	}	
	// Update is called once per frame
	void Update ()
	{
	}
	void OnMouseDown()
	{
		distance = Camera.main.WorldToScreenPoint (transform.position);
		posx = Input.mousePosition.x-distance.x;
		posy = Input.mousePosition.y-distance.y;
	}
	void OnMouseDrag()
	{
		Vector3 mousepos = new Vector3 (Input.mousePosition.x-posx,Input.mousePosition.y-posy,distance.z);
		Vector3 objpos = Camera.main.ScreenToWorldPoint (mousepos);
		model.transform.position = objpos;
	}
}
