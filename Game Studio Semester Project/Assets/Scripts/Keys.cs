using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
    public GameObject hide;
    public GameObject door;
    public Sprite open;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            hide.SetActive(false);
            door.GetComponent<SpriteRenderer>().sprite = open;
            door.GetComponent<SpriteRenderer>().flipX = false;
            door.GetComponent<Collider2D>().enabled = false;
            this.gameObject.SetActive(false);
        }
    }
}
