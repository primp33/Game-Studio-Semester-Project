using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Magic : MonoBehaviour
{
    public GameObject lightballPrefab;
    private Animator animator;
    public GameObject dontdestroy;
    private levelSystem levelsystem;
    public Animator playeranim;

    private void Start()
    {
        animator = GetComponent<Animator>();
        dontdestroy = GameObject.Find("DontDestroy");
        levelsystem = dontdestroy.GetComponent<levelSystem>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Spell();
            animator.SetBool("Space", true);
            playeranim.SetBool("attack", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("Space", false);
            playeranim.SetBool("attack", false);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            collision.gameObject.SetActive(false);
            levelsystem.currentXp += 20;
        }
    }
    //void Spell()
    //{
    //    Instantiate(lightballPrefab, gameObject.transform.position, gameObject.transform.rotation);
    //}
}

