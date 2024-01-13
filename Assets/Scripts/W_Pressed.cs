using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_Pressed : MonoBehaviour
{
    public AudioSource Wsound;
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Wsound.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}