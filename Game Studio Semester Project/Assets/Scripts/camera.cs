using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class camera : MonoBehaviour
{
    private GameObject player;
    private float camPos;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        camPos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        //replay
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (camPos < player.transform.position.x)
        {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        }
    }
}