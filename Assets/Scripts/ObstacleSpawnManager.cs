using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnManager : MonoBehaviour
{
    public GameObject spear, spike, suriken, player, spawner,mainMenu, scoreobj;
    int random, randomx ;
    float posx, timer, randomy;

    void Start()
    {
        timer = Random.Range(4, 12);        
    }

    void Update()
    {
        
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
            randomx = Random.Range(20, 31);
            posx = player.transform.position.x + randomx;
            random = Random.Range(0, 3);
                switch (random)
                {
                    case 0:
                        spawner.GetComponent<EnemySpawnManager>().Spawn(spear, new Vector3(posx, -2.701f, 0.89f));
                        break;
                    case 1:
                        spawner.GetComponent<EnemySpawnManager>().Spawn(spike, new Vector3(posx, -2.588f, 0.89f));
                        break;
                    case 2:
                        randomy = Random.Range(-1.28f, 2.43f);
                        spawner.GetComponent<EnemySpawnManager>().Spawn(suriken, new Vector3(posx, randomy, 0.89f));
                        break;
                }
                

                    timer = Random.Range(2, 3.5f);
                

                
            }
        }
    }
}
