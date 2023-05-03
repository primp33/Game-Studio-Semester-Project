using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextT1 : MonoBehaviour
{
    public GameObject textbox;
    public Text text;
    public string realtext;
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x > 39)
        {
            textbox.SetActive(false);
        }
        if (player.transform.position.x > 17 && player.transform.position.x < 39)
        {
            text.text = realtext;
            textbox.SetActive(true);
        }
    }
}
