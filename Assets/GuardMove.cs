using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardMove : MonoBehaviour
{
    int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   if(transform.position.x <= -6)
        {
            speed = 10;
        }     
   if (transform.position.x  >= 6){
            speed = -10;
        }
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}

//Was a little fun thing I added to make this all a little more unique ;D 
