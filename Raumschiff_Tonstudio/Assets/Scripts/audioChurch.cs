using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioChurch : MonoBehaviour
{
    //Dieses Skript startet die Audiodatei von der Kirche
    //bei Betreten des Colliders wird folgende Funktion ausgeführt
    void OnTriggerEnter(Collider other){
    
       //Die Audiodatei wird gestartet
      GetComponent<AudioSource>().Play();
    }

    void OnTriggerExit(Collider other){
    
       //Die Audiodateo wird gestoppt
      GetComponent<AudioSource>().Stop();
    }
}


