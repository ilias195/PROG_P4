using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SwitchScene : MonoBehaviour
{
    void Update()                      //Zorg dat de code elk frame wordt uitgevoerd
    {
        if (Input.GetKeyDown(KeyCode.Space))     //Check of de speler de spatie indrukt
        {
            SceneManager.LoadScene(1);  //Laad de "GameScene" in met de LoadScene methode
            Debug.Log("speler start het spel");
        }
    }
    
}
