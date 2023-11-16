using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletGoesPew : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
gameObject.transform.Translate(0,10*Time.deltaTime,0);
    if(transform.position.y>12)
    {
        Destroy(gameObject);
    }
        
    }
  
}
