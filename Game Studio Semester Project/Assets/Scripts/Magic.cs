using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic : MonoBehaviour
{
    public GameObject lightballPrefab;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Spell();
            animator.SetBool("Space", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("Space", false);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            collision.gameObject.SetActive(false);
        }
    }
    void Spell()
    {
        Instantiate(lightballPrefab, gameObject.transform.position, gameObject.transform.rotation);
    }
}

