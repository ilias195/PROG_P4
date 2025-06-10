using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    [SerializeField] private int speed = 5;//Maak een variabele voor je snelheid
    [SerializeField] private float timeLeft = 0;//Maak een variabele voor de overgebleven tijd
    [SerializeField] private int score = 0; //Maak een variabele voor je score
                                            //Zorg voor logische datatypes

    void Update()
    {
        // Beweging
        //laat de speler bewegen via de pijltjes en WASD toetsen
        float X = Input.GetAxis("Horizontal");
        float Z = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(X, 0, Z).normalized * speed * Time.deltaTime;  //Maak in je berekening gebruik van de speed en zorg voor vloeiende beweging ongeacht de framerate.


        transform.Translate(move);



        if (timeLeft <= 0)
        {

            Debug.Log("Game Over! Eindscore: " + score); //Als de tijd voorbij is stuur je een bericht naar de console met daarin "Game Over! Eindscore: " en je behaalde score.
            enabled = false; // Schakelt Update uit
            return; // stopt uitvoer van de rest van de code.
        }

        timeLeft -= Time.deltaTime;   //Haal de verstreken seconden tussen de frames van de tijd af


        
        Debug.Log("Tijd: " + Mathf.Round(timeLeft) + " | Score: " + score); //Laat in de console het aantal resterende seconden zien (afgerond) en je score

    }
    //zorg dat je een coin kan raken maar er niet tegenaan kan lopen. De speler moet door de coins heen kunnen.
    void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Coin"))//Check of je een coin hebt geraakt.
        {
            Debug.Log("Munt gepakt +10 punten"); //Stuur een bericht naar de console dat je een munt hebt gepakt en hoeveel punten dit oplevert
            score += 10;//Voeg 10 punten toe aan je score
            Destroy(other.gameObject);// Vernietig de geraakte coin
        }



    }
}

   
            
    





