using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 movement;
    private Rigidbody2D rb;
    public float speed = 5.0f;
    public float jumpForce = 500.0f;
    private bool isGrounded;
    private Collider2D collide;
    public Animator animAttack;
    public GameObject cooldown;
    private Vector3 begin;
    public Animator playeranim;
    public GameObject dontdestroy;
    private levelSystem levelsystem;
    private DontDestroy dontdes;
    public GameObject keytext;

    // Start is called before the first frame update
    void Start()
    {
        dontdestroy = GameObject.FindWithTag("DontDestroy");
        levelsystem = dontdestroy.GetComponent<levelSystem>();
        dontdes = dontdestroy.GetComponent<DontDestroy>();
        rb = GetComponent<Rigidbody2D>();
        collide = GetComponent<Collider2D>();
        begin = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (keytext.activeInHierarchy == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += movement * speed * Time.deltaTime;

        if (!(Input.GetAxis("Horizontal") == 0))
        {
            playeranim.SetBool("move", true);
        }

        if (Input.GetAxis("Horizontal") == 0)
        {
            playeranim.SetBool("move", false);
        }

        if (movement.x > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            cooldown.transform.localRotation = Quaternion.Euler(0, 0, 20);
        }
        if (movement.x < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            cooldown.transform.localRotation = Quaternion.Euler(0, 180, 20);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;
        }

        //hide function
        if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && isGrounded== true)
        {
            collide.enabled = false;
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
            speed = 0;
            animAttack.SetBool("hide", true);
            playeranim.SetBool("hide", true);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
        {
            collide.enabled = true;
            rb.constraints = RigidbodyConstraints2D.None;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            speed = 5;
            animAttack.SetBool("hide", false);
            playeranim.SetBool("hide", false);
        }

        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && isGrounded == true)
        {
            rb.AddForce(new Vector3(0.0f, jumpForce, 0.0f));
            isGrounded = false;
        }
        
        if (levelsystem != null)
        {
        //cooldown speed by level
        if (animAttack.GetCurrentAnimatorStateInfo(0).IsName("Cooldown"))
        {
            animAttack.speed = 1 + (levelsystem.level/2);
        }
        else
        {
            animAttack.speed = 1;
        }
        }
        else
        {
            if (animAttack.GetCurrentAnimatorStateInfo(0).IsName("Cooldown"))
            {
                animAttack.speed = 1 + (dontdes.level / 2);
            }
            else
            {
                animAttack.speed = 1;
            }
        }

    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Map"))
        {
            isGrounded = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Map"))
        {
            isGrounded = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("recharge") && animAttack.GetCurrentAnimatorStateInfo(0).IsName("Cooldown"))
        {
            animAttack.Play("Base Layer.Spirit");
        }
        if (collision.gameObject.CompareTag("EXP"))
        {
            collision.gameObject.SetActive(false);
            if (levelsystem != null)
            {
                levelsystem.currentXp += 40;
            }
            else
            {
            dontdes.currentXp += 40;
            }
        }
    }
}