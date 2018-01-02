using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelname : MonoBehaviour
{

    public TextMesh textMesh;

    void Start()
    {
        string LevelName = Application.loadedLevelName; //pobiera nazwę sceny i wyświetla ją
        textMesh.text = LevelName;

    }

}	
		

