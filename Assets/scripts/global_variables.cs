using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class global_variables : MonoBehaviour
{
    public static float score;
    public static float diametr;
    public static float radius_of_fall;
    public static float camera_height;

    // Use this for initialization
    void Start ()
    {
        score = 0;
        diametr = 20;
        radius_of_fall = 5;
        camera_height = 50;
		
	}
	
}
