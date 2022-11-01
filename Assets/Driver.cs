using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 100;
    [SerializeField] float DefaltSpeed = 10f;
    [SerializeField] float slowSpeed = 5f;
    [SerializeField] float boostSpeed = 20f;
    [SerializeField] float moveSpeed = 10;

    private void Start() 
    {
        moveSpeed = DefaltSpeed;    
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        moveSpeed = slowSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
