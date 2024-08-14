using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life;
   
  
    
    private void Awake()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")

        Destroy(other.gameObject);
        Destroy(this.gameObject);
        

    }
}