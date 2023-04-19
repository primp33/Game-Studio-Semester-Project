using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    private Vector3 movement;
    private float speed = 1;
    private float range = 1;
    private Animator animator;
    //private bool isGrounded;

    private void OnBecameVisible()
    {
        enabled = true;
    }
    private void OnBecameInvisible()
    {
        enabled = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
            transform.position += movement * speed * Time.deltaTime;

        if (player.transform.position.x > transform.position.x)
        {
            goRight();
        }
        if (player.transform.position.x < transform.position.x)
        {
            goLeft();
        }
        if (Mathf.Abs(player.transform.position.x - transform.position.x) < range)
        {
            animator.Play("Base Layer.Spin");
            speed = 2;
        }
        if (Mathf.Abs(player.transform.position.x - transform.position.x) < range)
        {
            animator.Play("Base Layer.Walk");
            speed = 1;
        }
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Spin2"))
        //{
            
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            animator.Play("Base Layer.Spin2");
        }
            //if (collision.gameObject.CompareTag("Map"))
            //{
            //    isGrounded = true;
            //}
    }

    private void goRight()
    {
        transform.localRotation = Quaternion.Euler(0, 0, 0);
        movement = Vector3.right;
    }
    private void goLeft()
    {
        transform.localRotation = Quaternion.Euler(0, 180, 0);
        movement = Vector3.left;
    }
}
