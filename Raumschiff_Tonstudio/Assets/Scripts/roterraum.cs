using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roterraum : MonoBehaviour
{
    //Dieses Skript startet die Audiodatei
    //bei Betreten des Colliders wird folgende Funktion ausgeführt
    void OnTriggerEnter(Collider other){
    
       //Die Audiodatei wird gestartet
      GetComponent<AudioSource>().Play();
    }

}
