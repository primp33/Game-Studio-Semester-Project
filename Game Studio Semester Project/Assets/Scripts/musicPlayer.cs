using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicPlayer : MonoBehaviour
{
    public AudioClip se;

    private AudioSource player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<AudioSource>();
        player.clip = se;
        player.loop = false;
        player.volume = 0.5f;
        player.Play();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            player.Play();
        }
    }
}
