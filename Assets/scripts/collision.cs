using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour 
{
    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "sphere") //sprawdza co wpadło na kolce
        {
            string LevelName = Application.loadedLevelName; //jeśli wystąpiła kolicja załaduj poziom od nowa
            Application.LoadLevel(LevelName);
        }
    }

		
	
}
