using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

    public Transform sphere;

	
	
	void Update ()
    {
        Rigidbody rigidbody = sphere.GetComponent<Rigidbody>(); //pobiera komponent fizyki
        
        Vector3 vector = new Vector3(0, 5f, -7f); //nowa pozycja kamery
        float velocity = rigidbody.velocity.sqrMagnitude; //pobiera prędkość kuli 
        vector = vector * (1f + velocity / 25f); //prękośc kamery zależy od prędkości kuli
        Vector3 newPosition = sphere.position + vector; //oblicza nową pozycje kamery

        
        
        transform.position = Vector3.Lerp(transform.position, newPosition,Time.deltaTime*4f); //nadaje płynność poruszania się kamery
        transform.LookAt(sphere); //kamera "patrzy" na środek kuli
	}
}
