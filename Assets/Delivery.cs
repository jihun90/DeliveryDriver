using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageCarColor = new Color32(200, 0, 0, 255);
    [SerializeField] Color32 noPackageCarColor = new Color32(255, 255, 255, 255);
    [SerializeField] float destroyDelay = 0.5f;
    
    SpriteRenderer spriteRenderer;
    bool hasPackage = false;

    private void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Collision!!!!!!");    
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if ((other.tag == "Package") && !hasPackage)
        {
            Debug.Log("Package!!!");
            hasPackage = true;
            spriteRenderer.color = hasPackageCarColor;
            Destroy(other.gameObject, destroyDelay);
        }
        
        if ((other.tag == "Customer") && hasPackage)
        {
            Debug.Log("Customer!!");
            spriteRenderer.color = noPackageCarColor;
            hasPackage = false;
        }
    }
}
