using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGrounds : MonoBehaviour
{
    public GameObject bg1, bg2, bg3, player;
    public float playerX, bg1X, bg1Speed, bg2X, bg2Speed, timer;

    // Start is called before the first frame update
    void Start()
    {
        playerX = player.transform.position.x;
        bg1X = playerX + 27.6439f;
        bg2X = playerX+ 100f;
        bg1Speed = 27.6439f;
        bg2Speed = 100f;
        timer = Random.Range(5, 12);
    }

    void FixedUpdate()
    {
        timer -= Time.deltaTime;
        playerX = player.transform.position.x;
        bg1.transform.position = new Vector3(bg1X, 0.43f, 9f);
        bg2.transform.position = new Vector3(bg2X, -0.78f, 8.5f);
        bg3.transform.position = new Vector3(bg2.transform.position.x + 4.79f, 2.58f, 8.5f);

        if ( timer<=0)
        {
            timer = Random.Range(5, 12);
        }


        if (bg1X>playerX-10.4961f)
        {
            bg1X = playerX + bg1Speed;
            bg1Speed -= 0.0055f;
        }
        else
        {
            bg1X = playerX + 27.6439f;
            bg1Speed = 27.6439f;
        }

        if (bg2X>playerX - 15f)
        {
            bg2X = playerX + bg2Speed;
            bg2Speed -= 0.065f;
        }
        else
        {
            bg2Speed = 100f;
            bg2X = playerX + bg2Speed;
        }


    }
}
