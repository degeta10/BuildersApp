using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class joystick : MonoBehaviour {
	private Rigidbody rb;
	public GameObject model; 
	public float speed=5.0f;
	private float rotx=0.0f;
	private float roty=0.0f;

	void Start () 
	{	
		rb = GetComponent<Rigidbody> ();
	}
	public void Update()
	{
		rotx-=CrossPlatformInputManager.GetAxis("Horizontal")*speed;
		roty+=CrossPlatformInputManager.GetAxis("Vertical")*speed;
		model.transform.eulerAngles = new Vector3 (roty,rotx,0f);

	}
}

