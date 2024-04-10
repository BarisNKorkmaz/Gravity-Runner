using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public GameObject mainMenu, canvas, pauseMenu, gameOverMenu;
    public bool gameStarted = false;
    public Animator scene;
    public float second = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
        pauseMenu.SetActive(false);
        gameOverMenu.SetActive(false);
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play() 
    {
        Time.timeScale = 1f;
        mainMenu.SetActive(false);
        gameStarted = true;
        canvas.SetActive(true);
    }

    public void restart()
    {
        StartCoroutine(wait());
    }

    public IEnumerator wait()
    {
        scene.SetTrigger("end");
        Time.timeScale = 1f;
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(0);
    } 

 
   

}
