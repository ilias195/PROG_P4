using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
  Rigidbody rb;
    float Movespeed;
    float JumpForce;
    [SerializeField] private bool IsOnFloor =false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Speler klaar!");
    }


    void Update()
    {

        float input = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * input * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && IsOnFloor)
        {

            rb.AddForce(Vector3(3f, 2f, 2f) *ForceMode.Impulse);
            

            IsOnFloor = false;
        }

    {
            void OnCollisionEnter(Collision collision)
            {
                if (collision.collider.CompareTag("Floor")) ;
                IsOnFloor=true;
            }
    }
    // Beweging met pijltjestoetsen
    // Beweeg blokje naar links en rechts met de pijltjestoetsen

    // Simpele Sprong met spatie , gebruik rigidbody


}
}
