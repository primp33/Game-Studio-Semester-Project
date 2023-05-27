using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Magic : MonoBehaviour
{
    public GameObject lightballPrefab;
    private Animator animator;
    public GameObject dontdestroy;
    private levelSystem levelsystem;
    public Animator playeranim;
    public int torch = 0;


    private void Start()
    {
        animator = GetComponent<Animator>();
        dontdestroy = GameObject.FindWithTag("DontDestroy");
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

        if (torch == 6)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            collision.gameObject.SetActive(false);
            levelsystem.currentXp += 20;
        }
        if (collision.gameObject.name == "torch")
        {
            collision.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            torch += 1;
        }
    }
    //void Spell()
    //{
    //    Instantiate(lightballPrefab, gameObject.transform.position, gameObject.transform.rotation);
    //}
}

