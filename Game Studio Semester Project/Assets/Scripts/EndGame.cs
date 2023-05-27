using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.Video;

public class EndGame : MonoBehaviour
{
    private VideoPlayer video;
    public GameObject videoplayer;
    public GameObject image;
    public GameObject sound;
    private AudioSource sound1;
    //public GameObject skip;

    // Start is called before the first frame update
    void Start()
    {
        video = videoplayer.GetComponent<VideoPlayer>();
        //image.SetActive(false);
        sound1 = sound.GetComponent<AudioSource>();
        //skip.SetActive(false);
        sound1.enabled = false;
        image.SetActive(true);
        video.enabled = true;
        video.loopPointReached += EndReached;
    }

    // Update is called once per frame
    //public void PlayED()
    //{
    //    //skip.SetActive(true);
    //    sound1.enabled = false;
    //    image.SetActive(true);
    //    video.enabled = true;
    //    video.loopPointReached += EndReached;
    //}
    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        vp.playbackSpeed = vp.playbackSpeed / 10.0F;
        video.enabled = false;
        sound1.enabled = true; 
        image.SetActive(false);
    }
}
