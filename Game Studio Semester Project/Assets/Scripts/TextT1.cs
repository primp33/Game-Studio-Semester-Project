using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class TextT1 : MonoBehaviour
{
    public GameObject textbox;
    private TextMeshProUGUI text;
    public string realtext;
    public GameObject player;
    void Start()
    {
        text = textbox.GetComponent<TextMeshProUGUI>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        text.text = realtext;
        textbox.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        textbox.SetActive(false);    
    }
}
