using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendLocal : MonoBehaviour {

    private LineRenderer lineRend;
    public Transform startPos;
    public Transform endPos;
    public KeyboardController kb;

    // Use this for initialization
    void Start () {
        lineRend = GetComponent<LineRenderer>();
    }
	
	// Update is called once per frame
	void Update () {

        lineRend.SetPosition(0, startPos.position);
	    //endPos.Rotate(0, 0, kb.alpha);
        lineRend.SetPosition(1, startPos.position + endPos.localPosition);
    }


}
