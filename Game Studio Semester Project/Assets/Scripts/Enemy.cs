using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    private Vector3 movement;
    private float speed = 1;
    private float range = 2;
    private Animator animator;
    private bool hit = false;
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
        if (((hit == false) && (Mathf.Abs(player.transform.position.x - transform.position.x) < 20) && (Mathf.Abs(player.transform.position.y - transform.position.y) < 4)))
            {
                transform.position += movement * speed * Time.deltaTime;
            }
            if (hit == true)
            {
                transform.position += movement * -speed * Time.deltaTime;
            }

            if (player.transform.position.x > transform.position.x)
            {
                goRight();
            }
            if (player.transform.position.x < transform.position.x)
            {
                goLeft();
            }
            if ((Mathf.Abs(player.transform.position.x - transform.position.x) < range) && (Mathf.Abs(player.transform.position.y - transform.position.y) < 1))
            {
                animator.SetBool("Near Player", true);
            }
            if (Mathf.Abs(player.transform.position.x - transform.position.x) > range)
            {
                animator.SetBool("Near Player", false);
                hit = false;
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                animator.Play("Base Layer.Spin2");
                hit = true;
            }
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
