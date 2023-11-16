using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newton : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject floor;
    int a=4;
    
    public GameObject balls;
    
    void Start()
    {
        
    }

    // Update is called once per frame
     void Update()
    {
       if(transform.position.x>7)
       {
           a=-4;
       }
       else if(transform.position.x<-7)
       {
           a=4;
       }
    gameObject.transform.Translate(a*Time.deltaTime,0,0);
        
    }

    void OnCollisionEnter (Collision other)
        {
            if(other.gameObject.tag=="you")
            {
                
            }
            if(other.gameObject.tag!="bullet")
            {
                if(other.gameObject.tag!="Respawn")
                {
                GetComponent<Rigidbody>().AddForce(0,500,0);
                }
            }
            else{
            ItsYouMan.b=ItsYouMan.b+1;
            
            Destroy(other.gameObject.transform.parent.gameObject);
            if(transform.localScale.x > .8f)
            {
            Vector3 diff = new Vector3(transform.localScale.x/4,0,0);
            GameObject temp = GameObject.Instantiate(balls,transform.position-diff,Quaternion.Euler(0,0,0));
            temp.transform.localScale = transform.localScale /2;
            temp.GetComponent<newton>().a=-4;
            temp.GetComponent<Rigidbody>().mass=gameObject.GetComponent<Rigidbody>().mass*1.2f;
            temp = GameObject.Instantiate(balls,transform.position+diff,Quaternion.Euler(0,0,0));
            temp.transform.localScale = transform.localScale /2;
            temp.GetComponent<Rigidbody>().mass=gameObject.GetComponent<Rigidbody>().mass*1.2f;
            temp.GetComponent<newton>().a=4;

            }
            Destroy(gameObject);
            }
        }
}
