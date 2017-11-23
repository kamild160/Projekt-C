using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherecontrol : MonoBehaviour
{
    int layer = 0;
    Rigidbody rigidbody;

    void Start()
    {
        rigidbody = transform.GetComponent<Rigidbody>(); //pobiera komponent fizyki
    }
    void Update()
    {
        changeLayer();
        changePosition();
    }

    void changeLayer()
    {
        //zmiana wartsw
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            

            bool isSomething = Physics.Raycast(transform.position, Vector3.forward, 2f); //sprawdza czy coś znajduje się na drodze kuli

            if (!isSomething )
            {
                layer = 1;
            }
           
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            bool isSomething = Physics.Raycast(transform.position, Vector3.back, 2f); //sprawdza czy coś znajduje się na drodze kuli

            if (!isSomething)
            {
                layer = 0;
            }
        }

        //przechodzenie warstw
        float delta = (layer * 2f - 2f) - rigidbody.position.z ;

        Vector3 velocity = rigidbody.velocity; //pobiera prędkość
        velocity.z = delta * 3f; //zmiana prędkości 
        rigidbody.velocity = velocity;

    }

    void changePosition()
    //sterowanie prawo lewo
    {
        Vector3 direction = Vector3.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = Vector3.forward;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = -Vector3.forward;
        }

        rigidbody.AddTorque(direction * 10f); //dodaje do komponentu fizyki moment obrotowy
    }
}