using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{

    public float speed = 0;
    public float maxSpeed=0.5f;
    public Animator animator;
    public GameObject mainMenu, score;
    bool playing;

    private void FixedUpdate()
    {
            if (this.transform.position.x < 50) //Ýlerlemeye göre maxSpeed arttýrma
        {
            maxSpeed = 0.5f;
        }

            else if (this.transform.position.x < 100 && this.transform.position.x > 50)
        {
                maxSpeed = 0.533f;
        }
            else if (this.transform.position.x < 150 && this.transform.position.x > 100)
        {
            maxSpeed = 0.566f;
        }
            else if (this.transform.position.x < 200 && this.transform.position.x > 150)
        {
            maxSpeed = 0.599f;
        }

            else if (this.transform.position.x < 300 && this.transform.position.x > 200)
        {
            maxSpeed = 0.65f;
        }
            else if (this.transform.position.x < 400 && this.transform.position.x > 300)
        {
            maxSpeed = 0.7f;
        }
            else if (this.transform.position.x < 500 && this.transform.position.x > 400)
        {
            maxSpeed = 0.75f;
        }
            else if (this.transform.position.x < 750 && this.transform.position.x > 500)
        {
            maxSpeed = 0.8f;
        }
            else if (this.transform.position.x < 1000 && this.transform.position.x > 750)
        {
            maxSpeed = 0.85f;
        }
            else if (this.transform.position.x < 2000 && this.transform.position.x > 1000)
        {
            maxSpeed = 0.9f;
        }
            else if (this.transform.position.x>2000)
        {
            maxSpeed = 1.05f;
        }


        if (speed < maxSpeed)
        {
            speed += 0.01f;
        }
        else if (speed >= maxSpeed)
        {
            speed = maxSpeed;
        }

        this.transform.position += new Vector3(speed, 0, 0)*Time.deltaTime*20f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Enemy")
        {
            score.GetComponent<Score>().GameOverScore();
            Time.timeScale = 0;
        }
        else if (collision.gameObject.tag == "Obstacle")
        {
            score.GetComponent<Score>().GameOverScore();
            Time.timeScale = 0;
        }
        
        if (collision.gameObject.tag=="Road")
        {
            animator.SetBool("Active", false);
        }
    }

    private void Update()
    {
        playing = mainMenu.GetComponent<MainMenu>().gameStarted;

        if (playing == false)
        {
            animator.SetBool("GameStart", false);
        }
        else
        {
            animator.SetBool("GameStart", true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Road")
        {
            animator.SetBool("Active", true);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Road")
        {
            animator.SetBool("Active", false);
        }
    }

}
