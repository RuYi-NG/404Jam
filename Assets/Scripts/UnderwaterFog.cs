using UnityEngine;
using System.Collections;
 
public class Underwater: MonoBehaviour {
 
private Color underwaterColor;

[SerializeField] Color fogColor = new Color(0.22f, 0.65f, 0.77f, 0.5f);
    [SerializeField] float fogDensity = 0.002f;

    // Use this for initialization
    void Start () {
    underwaterColor = fogColor;
}
 
// Update is called once per frame
void Update () {
    RenderSettings.fog = true;
    RenderSettings.fogColor = underwaterColor;
    RenderSettings.fogDensity = fogDensity;
}

 }