using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour {

    //Dieses Skript lädt den roten Raum, wenn die Kapseln verlassen werden sollen
    public void OnTriggerEnter(Collider collider) // Trigger deklarieren, der bei Berühung mit Kamera auslöst
    {
    SceneManager.LoadScene(2); // Beim Auslösen, lädt hier angegebene Szene
    }

   
}
