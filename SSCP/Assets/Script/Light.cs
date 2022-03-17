using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int RotationX = 90;

        RotationX ++;
        if (transform.eulerAngles.x < 175)
        {  
            transform.Rotate(0.02f,0,0);
        }
    }
}
