using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject PauseMenu, mainMenu, cam, redLine, redLine1;
    public bool pause=false;
    
    public void Sounds()
    {
    
        if (cam.GetComponent<AudioSource>().enabled == false)
        {
            cam.GetComponent<AudioSource>().enabled = true;
            redLine.SetActive(false);
            redLine1.SetActive(false);
        }
        else
        {
            cam.GetComponent<AudioSource>().enabled = false;
            redLine.SetActive(true);
            redLine1.SetActive(true);
        }

    }

    public void GameStop()
    {
        if ( pause == false)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
            pause= true;
            mainMenu.GetComponent<MainMenu>().gameStarted= false;
        }
        else
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1f;
            pause= false;
            mainMenu.GetComponent<MainMenu>().gameStarted = true;
        }


    }

    public void print()
    {
        print("YESorNO");
    }

}
