using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + global_variables.camera_height, transform.position.z - global_variables.camera_height);
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + global_variables.camera_height, transform.position.z - global_variables.camera_height);
    }
}
