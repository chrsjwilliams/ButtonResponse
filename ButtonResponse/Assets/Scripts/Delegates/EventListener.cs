using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListener : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventFireer.ClassRegistrationIsOpen += OnClassRegistrationOpen;
    }

    private void OnDestroy()
    {
        EventFireer.ClassRegistrationIsOpen -= OnClassRegistrationOpen;
    }

    private void OnClassRegistrationOpen(string str)
    {
        Debug.Log("Register for classes! " + str);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
