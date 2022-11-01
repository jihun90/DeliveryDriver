using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Collision!!!!!!");    
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Package")
        {
            Debug.Log("Package!!!");
        }
        
        if (other.tag == "Customer")
        {
            Debug.Log("Customer!!");
        }
    }
}
