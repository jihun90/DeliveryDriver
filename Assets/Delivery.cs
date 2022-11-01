using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Collision!!!!!!");    
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Package")
        {
            Debug.Log("Package!!!");
            hasPackage = true;
        }
        
        if ((other.tag == "Customer") && hasPackage)
        {
            Debug.Log("Customer!!");
            hasPackage = false;
        }
    }
}
