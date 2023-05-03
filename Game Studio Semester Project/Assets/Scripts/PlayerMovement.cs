using System.Collections;
using System.Collections.Generic;
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

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collide = GetComponent<Collider2D>();
        begin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += movement * speed * Time.deltaTime;

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
        }
        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
        {
            collide.enabled = true;
            rb.constraints = RigidbodyConstraints2D.None;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            speed = 5;
            animAttack.SetBool("hide", false);
        }

        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && isGrounded == true)
        {
            rb.AddForce(new Vector3(0.0f, jumpForce, 0.0f));
            isGrounded = false;
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
        if (collision.gameObject.CompareTag("recharge"))
        {
            animAttack.Play("Base Layer.Spirit");
        }
    }
}