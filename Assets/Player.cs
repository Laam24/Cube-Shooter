using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed;
    float speedX, speedY;

    private void Start()
    {   
        
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        
        rb.velocity = new Vector2 (speedX, speedY);
        rb.velocity.Normalize ();

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            
            Destroy(gameObject);
        }
    }

    


}
