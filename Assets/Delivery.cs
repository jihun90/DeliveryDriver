using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destroyDelay = 0.5f;
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
            Destroy(other.gameObject, destroyDelay);
        }
        
        if ((other.tag == "Customer") && hasPackage)
        {
            Debug.Log("Customer!!");
            hasPackage = false;
        }
    }
}
