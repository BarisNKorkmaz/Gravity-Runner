using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPosition : MonoBehaviour
{
    
    float speed, timer;


    // Start is called before the first frame update
    void Start()
    {
        timer = 10;
        speed = 2;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timer > 0 && timer > 5)
        {
            timer -= Time.deltaTime;
            this.transform.eulerAngles = new Vector3(0, 180, 0);
            this.transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }
        else if (timer > 0 && timer < 5) 
        {
            timer -= Time.deltaTime;
            this.transform.eulerAngles = new Vector3(0, 0, 0);
            this.transform.position += new Vector3(speed * -1, 0, 0) * Time.deltaTime;
        }
        else if (timer<=0)
        {
            timer= 10;
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Destroyer")
        {
            Destroy(this.gameObject);
        }
    }

}
