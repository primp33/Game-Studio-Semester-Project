using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class camera : MonoBehaviour
{
    private GameObject player;
    private Vector3 camPos;
    public float xEnd = 51;
    private Vector3 begin;
    private Vector3 begin1;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        camPos = transform.position;
        begin = player.transform.position;
        begin1 = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, player.transform.position.y+0.5f, transform.position.z);

        if (camPos.x < player.transform.position.x)
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y+0.5f, transform.position.z);
        }

        if ((player.transform.position.y < -20) || (player.transform.position.x < begin.x))
        {
            transform.position = begin1;
            player.transform.position = begin;
        }

    }
}