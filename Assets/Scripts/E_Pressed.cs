using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Pressed : MonoBehaviour
{
    public AudioSource Esound;
    public KeyCode keyCode;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            Esound.Play();
        }
    }
}