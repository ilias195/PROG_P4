using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManger : MonoBehaviour
{
    [SerializeField] private  int score =  0; // Zorg voor een variabele met je startscore

    // Maak een methode AddScore die vanaf een ander script aangeroepen kan worden en waaraan je de gescoorde punten mee kunt geven als argument.
    public void AddScore(int punten)
    {
        score += punten;  // tel de punten op bij de score

        Debug.Log("Munt gepakt" + punten + "punten"); //Stuur bericht naar de console dat je een munt hebt gepakt!
    }
    
        
    
}
