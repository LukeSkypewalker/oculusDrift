using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : MonoBehaviour
{
    public float alpha;
    public float rotationSpeed = 0.5f;

	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
	    alpha = Input.GetAxis("Horizontal")*rotationSpeed;
	}
}
