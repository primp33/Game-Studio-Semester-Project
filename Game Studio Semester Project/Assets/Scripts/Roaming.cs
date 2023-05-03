using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roaming : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 2;
    private Vector3 start;
    public float end;
    private Vector3 begin;
    public GameObject cam;
    private Vector3 campos;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = -transform.right * speed;
        campos = cam.transform.position;
        start = transform.position;
        begin = GameObject.FindWithTag("Player").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < end)
        {
            transform.position = start;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.position = begin;
            cam.transform.position = campos;
        }
    }
}
