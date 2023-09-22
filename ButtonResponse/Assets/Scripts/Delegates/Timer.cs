using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public static event Action TimeIsOver;

    float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // time is going down
        if(time <= 0)
        {
            TimeIsOver?.Invoke();
        }

    }
}
