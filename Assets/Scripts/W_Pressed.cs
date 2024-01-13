using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_Pressed : MonoBehaviour
{
    public AudioSource Wsound;
    public KeyCode keyCode;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            Wsound.Play();
        }
    }
}