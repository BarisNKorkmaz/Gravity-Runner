using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    Vector2 grvty = new Vector2(0, -10f);
    Vector2 reversegravity = new Vector2(0, 10f);
    public GameObject mainMenu;

    void Start()
    {
        Physics2D.gravity = grvty;
    }
    private void Update()
    {
      /*if (mainMenu.GetComponent<MainMenu>().gameStarted == true) 
      { 

        if (Physics2D.gravity == grvty && Input.GetMouseButtonDown(0) == true)
        {
            Physics2D.gravity = new Vector2(0,0);
            Physics2D.gravity = reversegravity; // ters gravity
        }
        else if (Physics2D.gravity == reversegravity && Input.GetMouseButtonDown(0) == true)
        {
            Physics2D.gravity = new Vector2(0, 0);
            Physics2D.gravity = grvty; //gravity'i normale döndürme
        }

        if (Physics2D.gravity == grvty)//rotation sabitleme
        {
            this.transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (Physics2D.gravity == reversegravity)
        {
            this.transform.eulerAngles = new Vector3(0, 180, 180);
        }
      }*/
    }

    public void RotateGravity()
    {        

            if (Physics2D.gravity == grvty)
            {
                Physics2D.gravity = new Vector2(0, 0);
                Physics2D.gravity = reversegravity; // ters gravity
            }
            else if (Physics2D.gravity == reversegravity)
            {
                Physics2D.gravity = new Vector2(0, 0);
                Physics2D.gravity = grvty; //gravity'i normale döndürme
            }

            if (Physics2D.gravity == grvty)//rotation sabitleme
            {
                this.transform.eulerAngles = new Vector3(0, 0, 0);
            }
            else if (Physics2D.gravity == reversegravity)
            {
                this.transform.eulerAngles = new Vector3(0, 180, 180);
            }
        
    }

}
