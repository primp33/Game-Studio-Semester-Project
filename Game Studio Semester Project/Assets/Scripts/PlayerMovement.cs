using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 movement;
    private Rigidbody2D rb;
    public float speed = 10.0f;
    public float jumpForce = 500.0f;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += movement * speed * Time.deltaTime;

        if (movement.x > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (movement.x < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;
        }

        //float moveHorizontal = Input.GetAxis("Horizontal");
        //movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
        //rb.AddForce(movement * speed);

        //if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        //{
        //    Vector2 vel = rb.velocity;
        //}

        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded == true)
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
}