using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardController : MonoBehaviour
{
    public Transform bottom;
    private Transform center;
    public float k=1;
	// Use this for initialization
	void Start ()
	{
	    center = transform;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    float alpha = Input.GetAxis("Horizontal");
        center.Rotate(0, 0, alpha);
        bottom.Rotate(0, 0, k*-alpha);

	}
}
