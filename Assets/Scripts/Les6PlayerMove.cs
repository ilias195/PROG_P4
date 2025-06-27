using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Les6PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed = 0f;

  
    void Update()
    {
        //Zorg dat de speler over de x en z as bestuurd kan worden
        float moveZ = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
        float moveX = Input.GetAxis("Vertical") * speed * Time.deltaTime; 

        transform.Translate(moveX, 0f, moveZ);
        
    }
}
