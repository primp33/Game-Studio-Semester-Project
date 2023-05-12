using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;


public class Keys : MonoBehaviour
{
    public GameObject textbox;
    public Text text;
    public int key = 0;
    public GameObject[] hide;
    public GameObject portal;
    //public GameObject picture;
    public Image Picture;
    public List<string> realtext = new List<string>();
    public List<Sprite> images = new List<Sprite>();
    void Start()
    {
        portal.SetActive(false);
        //Picture = picture.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (key == hide.Length)
        {
            portal.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("key"))
        {
            text.text = realtext[key];
            Picture.GetComponent<Image>().sprite = images[key];
            hide[key].SetActive(false);
            textbox.SetActive(true);
            //hide[key].SetActive(false);
            collision.gameObject.SetActive(false);
            Time.timeScale = 0;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("key"))
        {
            key += 1;
        }
    }
}
