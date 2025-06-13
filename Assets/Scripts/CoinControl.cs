using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinControl : MonoBehaviour
{
    [SerializeField] private float speed = 1f; //Maak een speed variabele die aanpasbaar is in de Inspector
    [SerializeField] GameObject coinPrefab; // Maak een variabele voor je prefab


    void Start()
    {
        float randomX = Random.Range(-10f, 10f);  //Maak een random waarde tussen de -10 en de 10 voor het plaatsen van een munt op de x-as
        Instantiate(coinPrefab, new Vector3(randomX, 0, 0), Quaternion.Euler(90, 0, 0)); //Gebruik de Instantiate methode om de coinPrefab op een random x-positie in de scene te zetten.
        Debug.Log("Coin is gespawnt");
        Instantiate(coinPrefab, new Vector3(0, 0, 0), Quaternion.Euler(90, 0, 0));
    }

    void Update()
    {
        
        float input = Input.GetAxis("Horizontal");
       
        transform.Translate(speed * Vector3.right * input *Time.deltaTime);//Vermenigvuldig de richting met de snelheid en de horizontale input waarde
        //Beweeg de speler ging met pijltjestoetsen links en rechts of A en D
       
    }
}
