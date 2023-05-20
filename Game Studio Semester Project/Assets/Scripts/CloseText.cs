using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseText : MonoBehaviour
{
    public GameObject textbox;
    public void Close()
    {
        textbox.SetActive(false);
        Time.timeScale = 1;
    }
}
