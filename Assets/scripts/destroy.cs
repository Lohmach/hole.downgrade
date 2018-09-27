using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public Terrain tr;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.y - tr.transform.position.y < -10)
        {
            Destroy(gameObject);
            Rigidbody mm = GetComponent<Rigidbody>();
            global_variables.score += mm.mass;
            global_variables.diametr += mm.mass;
            global_variables.camera_height += mm.mass;
            global_variables.radius_of_fall = global_variables.diametr / 4;
        }
	}
}
