using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // To Do's:
    [SerializeField] private int score = 0;
    // Private Variabele voor score type int

    // Private List voor "Coins" type int
    private List<int> Coins = new List<int>();

    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            Debug.Log("start");
        }
        // Loop: toon 3x een startbericht met Debug.Log in een loop

    }

    void Update()
    {
        // If-statement: check of score >= 50
        for (int i = 0; i >= 50; i++)
        {

            Debug.Log("je hebt gewonnen");
            // Zo ja geef een bericht met Debug.Log dat je hebt gewonnen

        }
        // Test: druk op spatie om een munt toe te voegen
        if (Input.GetKeyDown(KeyCode.Space))
        {


            {
                AddCoin(Random.Range(0, 50));

                // Roep functie AddCoin aan en geef de waarde van de coin mee
                // Gebruik Random.Range(int min, int max) om een random waarde aan je coin te geven
            }
           // Debug.Log("Aantal munten: " + coins.Count);)
            

        }

        // Functie om een munt toe te voegen
        void AddCoin(int coinValue)
        {
            Coins.Add(coinValue); // Voeg munt toe aan lijst

            score += coinValue; // Verhoog score met de coin value

            Debug.Log("Aantal munten: " + coinValue + " nieuwe score" + score);



        }
    }
}
