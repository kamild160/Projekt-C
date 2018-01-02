using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crystal : MonoBehaviour

{
    public GameObject particles; 




    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name != "sphere")  // sprawdza czy obiakt zderzył się z kulą
        {

            return;

        }

        if( crystalsleft()==1)
        {
            SceneManager.LoadScene("win"); // po zebranu sszystkich elementów
        }
        else 
        {
            Instantiate(particles,transform.position,Quaternion.identity); //działanie zrobłysku
            Destroy(gameObject, 0.1f);
        }
     }



    int crystalsleft()
    {
        crystal[] crystals= Component.FindObjectsOfType<crystal>();
        return crystals.Length;
    }
}
