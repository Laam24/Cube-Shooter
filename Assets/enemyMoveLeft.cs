using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemyMoveLeft : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform tr;

    public GameObject player;

    


    // Start is called before the first frame update
    void Start()
    {

        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        float enemySpeed = Random.Range(3.5f, 5.5f);
        rb.velocity = transform.right * enemySpeed;

        



    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Des"))
        {
            
            Destroy(gameObject);
            
        }



    }



}

