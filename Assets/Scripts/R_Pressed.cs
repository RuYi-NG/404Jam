using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_Pressed : MonoBehaviour
{
    public AudioSource Esound;
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Rsound.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}