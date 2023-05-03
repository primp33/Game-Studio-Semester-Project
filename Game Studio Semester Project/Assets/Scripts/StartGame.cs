using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.Video;

public class StartGame : MonoBehaviour
{
    private VideoPlayer video;
    public GameObject videoplayer;
    public GameObject image;
    public GameObject sound;
    private AudioSource sound1;
    public GameObject skip;

    public void Start()
    {
        video = videoplayer.GetComponent<VideoPlayer>();
        image.SetActive(false);
        sound1 = sound.GetComponent<AudioSource>();
        skip.SetActive(false);
}
    public void StartMenu()
    {
        skip.SetActive(true);
        sound1.enabled = false;
        image.SetActive(true);
        video.enabled = true;
        video.loopPointReached += EndReached;
    }

    public void SkipMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        vp.playbackSpeed = vp.playbackSpeed / 10.0F;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
