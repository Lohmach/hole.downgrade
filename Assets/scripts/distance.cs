using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distance : MonoBehaviour {

    public GameObject hole;
    public GameObject lie;

    // Use this for initialization
    void Start ()
    {
            
	}
	
	// Update is called once per frame
	void Update ()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if (((Mathf.Abs(transform.position.x - hole.transform.position.x) < global_variables.radius_of_fall) &&
            (Mathf.Abs(transform.position.z - hole.transform.position.z) < global_variables.radius_of_fall)) &&
            (global_variables.diametr / 3 >= transform.localScale.x))
        {

            rb.useGravity = true;

        }

        //if (transform.position.y - lie.transform.position.y > transform.localScale.y/2 + 2)
        //{
        //    rb.useGravity = true;
        //}
        //тут нужен стопор для предотвращения падения сквозь фальштеррейн, если дыра убежала
        //не конфликтующий с условием падения
        //2:30 пока не придумывается...
        //3:00 кубы красиво улетают в закат с выключенной гравитацией если их выкидывает из дыры,
        //поэтому не выбрасывай подумой

        else rb.useGravity = false; 
    }
}
