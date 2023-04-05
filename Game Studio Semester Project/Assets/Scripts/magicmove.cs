using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magicmove : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    //void onTriggerEnter2D(Collider2D collision)
    //{
    //    if(collision.gameObject.CompareTag("enemy"))
    //    {
    //        Destroy(gameObject);
    //    }

    //}
}
