using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public Transform bottom;
    public Transform seat;
    public KeyboardController kb;

    public float k=1;

	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
	    float alpha = kb.alpha;
        seat.Rotate(0, 0, alpha/2f);
        bottom.Rotate(0, 0, k*-alpha);

	}
}
