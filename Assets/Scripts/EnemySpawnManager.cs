using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject player, slime, skeleton, bat, flyeye, dino, mainMenu, scoreobj;
    Vector3 pos;
    int random;
    float timer, randomY;

    public void Spawn(GameObject enemy, Vector3 pos)
    {
        Instantiate(enemy, pos, Quaternion.identity);
    }

    void Start()
    {
        timer = UnityEngine.Random.Range(2, 12);
    }

    private void FixedUpdate()
    {
        if (mainMenu.GetComponent<MainMenu>().gameStarted == true)
        {


            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }

            if (timer <= 0)
             {
                 random = UnityEngine.Random.Range(0, 5);

                 switch (random)
                 {
                     case 0:
                         pos = new Vector3(player.transform.position.x + 30, 3.35f, 0);
                         Spawn(slime, pos);
                         break;

                     case 1:
                         pos = new Vector3(player.transform.position.x + 30, -2.35f, 0);
                         Spawn(skeleton, pos);
                         break;

                     case 2:
                         randomY = UnityEngine.Random.Range(-1, 3.5f);
                         pos = new Vector3(player.transform.position.x + 30, randomY, 0);
                         Spawn(bat, pos);
                         break;

                     case 3:
                         randomY = UnityEngine.Random.Range(-1, 3.5f);
                         pos = new Vector3(player.transform.position.x + 30, randomY, 0);
                         Spawn(flyeye, pos);
                         break;

                     case 4:
                         pos = new Vector3(player.transform.position.x + 30, -2.35f, 0);
                         Spawn(dino, pos);
                         break;
                 }


                    timer = UnityEngine.Random.Range(2, 4);
                
                

             }
        }
    }

  

}
