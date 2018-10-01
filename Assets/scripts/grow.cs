using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grow : MonoBehaviour
{

    public static Transform tr;
	// Use this for initialization
	void Start ()
    { 
    }
	
	// Update is called once per frame
	void Update ()
    {
        tr = GetComponent<Transform>();
        tr.localScale = new Vector3(global_variables.diametr, 80, global_variables.diametr);
    }
}
