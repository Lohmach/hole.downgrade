using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distance : MonoBehaviour {

    public GameObject hole;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        //if ((Vector3.Distance(transform.position, hole.transform.position) <= global_variables.radius_of_fall))// && (global_variables.radius/2 >= transform.localScale.x))
        if (((Mathf.Abs(transform.position.x - hole.transform.position.x) < global_variables.radius_of_fall) &&
            (Mathf.Abs(transform.position.z - hole.transform.position.z) < global_variables.radius_of_fall)) && 
            (global_variables.diametr / 2 >= transform.localScale.x))
        {
            BoxCollider bc = GetComponent<BoxCollider>();
            //MeshCollider mc = GetComponent<MeshCollider>();
            bc.enabled = false;
            //mc.enabled = false;
        }
    }
}
