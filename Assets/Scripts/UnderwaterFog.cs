 using UnityEngine;
 using System.Collections;
 
 public class Underwater: MonoBehaviour {
 
 private Color underwaterColor;
 
 // Use this for initialization
 void Start () {
     underwaterColor = new Color (0.22f, 0.65f, 0.77f, 0.5f);
 }
 
 // Update is called once per frame
 void Update () {
     RenderSettings.fog = true;
     RenderSettings.fogColor = underwaterColor;
     RenderSettings.fogDensity = 0.01f;
 }

 }