using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private float firstPos, pos, score;
    public GameObject player, gameOverPanel, particles, cam;
    public TMP_Text Text, gOver;
    string x;
    public int scr, lastScr;
        
    // Start is called before the first frame update
    void Start()
    {
        firstPos = player.GetComponent<Transform>().position.x;
    }

    // Update is called once per frame
    void Update()
    {
        pos = player.transform.position.x;
        score = pos - firstPos;
        scr = Convert.ToInt32(score);
        x = scr.ToString();
        Text.text = x;
        
    }

     public void GameOverScore()
    {
        lastScr= scr;
        gOver.text=lastScr.ToString();
        gameOverPanel.SetActive(true);
        particles.SetActive(false);
        cam.GetComponent<AudioSource>().volume = 0.5f;
        Time.timeScale = 0;
    }

}