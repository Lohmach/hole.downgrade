using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gui : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), global_variables.score.ToString());
    }
}
