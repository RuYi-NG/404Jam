using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q_Pressed : MonoBehaviour
{
    public AudioSource Qsound;
    public KeyCode keyCode;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            Debug.Log("hi");
            Qsound.Play();
        }
    }
}
