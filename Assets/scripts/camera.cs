using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject Main_Camera;

    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        Main_Camera.GetComponent<Camera>().fieldOfView = global_variables.camera_height;
    }
}
