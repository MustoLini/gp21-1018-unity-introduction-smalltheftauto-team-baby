using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collison)
    {
        Destroy(gameObject);
        Destroy(gameObject, 4f);
        
       
    } 
}
