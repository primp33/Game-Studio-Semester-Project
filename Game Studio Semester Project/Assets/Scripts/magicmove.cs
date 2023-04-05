using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magicmove : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    private Vector2 start;

    void Start()
    {
        start = transform.position;
        rb.velocity = transform.right * speed;
    }

<<<<<<< HEAD
    void onTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            collision.gameObject.SetActive(false);
            //Destroy(gameObject);
        }

=======
    private void Update()
    {
        //Didn't we want a range for our attack?

        //if (gameObject.transform.position.x > start.x+5)
        //{
        //    Destroy(gameObject);
        //}
    }

    //Attack dissapears on contact with enemy or leaving the screen
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Map"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("enemy"))
        {
            collision.gameObject.SetActive(false);
            Destroy(gameObject);
        }
>>>>>>> 268c0c40a10535beb43bb79ad253d9eec49f9462
    }
}
