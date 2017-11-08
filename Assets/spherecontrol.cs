using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherecontrol : MonoBehaviour
{


	
	
	void Update ()
    {
        Rigidbody rigidbody = transform.GetComponent<Rigidbody>();//pobiera komponent fizyki

        Vector3 direction=Vector3.zero; //zmienna kierunku

        //sterowanie 

		if(Input.GetKey(KeyCode.UpArrow))
        {
            direction =-Vector3.left;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction= Vector3.left;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
           direction= Vector3.forward;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
           direction= -Vector3.forward;
        }
        rigidbody.AddTorque(direction * 10f); //do komponentu fizyki odaje moment obrotowy
    }
}
