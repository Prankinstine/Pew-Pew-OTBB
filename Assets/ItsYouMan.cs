using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItsYouMan : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public GameObject over_screen;
    public GameObject boss_screen;
    public GameObject MoB_screen;
    public GameObject sinister_screen;
    public GameObject stage;
    float a=0;
    float t=100000;
    float q= 333333;
    float v = 0.5f;
    int p = 0;
    int o = 0;
    public static int b;
    public GameObject Win_screen;
    int l = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    async void Update()
    {
        if (l == 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                if (Time.time - a >= v)
                {
                    Instantiate(bullet, transform.position + new Vector3(0, 1, 0), Quaternion.Euler(0, 0, 0));
                    a = Time.time;
                }

            }
            if (Input.GetKey(KeyCode.A))
            {
                if (transform.position.x > -7)
                {
                    gameObject.transform.Translate(-6 * Time.deltaTime, 0, 0);
                }
            }
            if (Input.GetKey(KeyCode.D))
            {
                if (transform.position.x < 7)
                {
                    gameObject.transform.Translate(6 * Time.deltaTime, 0, 0);
                }
            }
        }
         if(b==14)
            {
                Win_screen.SetActive(true);
              t= Time.time;
              b=b+1;
             
            }
         if(Time.time-t>3 && o==0 )
            {
                Win_screen.SetActive(false);
                boss_screen.SetActive(true);
                GameObject.Destroy(stage);
                q = Time.time;
            o = 1;
            v = 5;
        }
         if(p==0)
        {
            if(Time.time-q>9)
            {
                boss_screen.SetActive(false);
                sinister_screen.SetActive(true);
            }
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Respawn")
        {

            over_screen.SetActive(true);
            l = 1;
        }
        if (other.gameObject.tag == "GameController")
        {
            Destroy(gameObject);
            sinister_screen.SetActive(false);
            boss_screen.SetActive(false);
            MoB_screen.SetActive(true);
            p = 1;
        }
    }

}
