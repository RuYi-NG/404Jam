using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q_Pressed : MonoBehaviour
{
    public AudioSource Qsound;
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Qsound.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
