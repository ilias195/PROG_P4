using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Referentie naar Rigidbody
    // Snelheid van bewegen moveSpeed type float
    // Kracht van sprong jumpForce type float
    Rigidbody rb;
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    Vector3 jump;
    [SerializeField] private bool isOnFloor = false;

    void Start()
    {
        // Haal Rigidbody component op van het gameobject
        rb = GetComponent<Rigidbody>();
        Debug.Log("Speler klaar!");
        jump = new Vector3(0.0f, 1.0f, 0.0f); 
    }

    void Update()
    {
        // Beweging met pijltjestoetsen
        // Beweeg blokje naar links en rechts met de pijltjestoetsen

        // Simpele Sprong met spatie , gebruik rigidbody

        float input = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * input * moveSpeed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && isOnFloor)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isOnFloor = false;
            Debug.Log("Springt");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Floor"))
        {   
            isOnFloor = true;
        }
    }
}
