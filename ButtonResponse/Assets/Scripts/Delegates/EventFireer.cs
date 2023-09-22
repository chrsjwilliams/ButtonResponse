using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventFireer : MonoBehaviour
{
    public static event Action<string> ClassRegistrationIsOpen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ClassRegistrationIsOpen.Invoke("Mobile Game Studio");
        }
    }
}
