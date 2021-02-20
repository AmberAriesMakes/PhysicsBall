using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z <= -20.89)              // So that ball also returns when past the goalie

        {
            transform.position = new Vector3(-1, 13, 3);

        }
    }
}
