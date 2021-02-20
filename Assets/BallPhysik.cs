using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPhysik : MonoBehaviour
{
    float LongRotationX, TallRotationY = 0f;  
    public Rigidbody ball;
    

    public float vol = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z <= -20.89)                         // Reset for when ball gets past goalie 
        {
            transform.position = new Vector3(-1, 13, 3);

        }
        if (Input.GetMouseButtonUp(0))
        {
            ball.velocity = transform.forward * vol;
        }
        transform.position = ball.position;

        if (Input.GetMouseButton(0))                               //Aim to look
        {
            LongRotationX += Input.GetAxis("Mouse X");
            TallRotationY += Input.GetAxis("Mouse Y");
            transform.rotation = Quaternion.Euler(TallRotationY, LongRotationX, 0f);
        }
      

        
    }
}
