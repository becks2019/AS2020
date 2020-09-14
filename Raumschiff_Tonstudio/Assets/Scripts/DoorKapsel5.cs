using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorKapsel5 : MonoBehaviour
{
    //Dieses Skript lädt die jeweilige Kapsel, welche betreten werden sollen
    public void OnTriggerEnter(Collider collider) // Trigger deklarieren, der bei Berühung mit Kamera auslöst
    {
    SceneManager.LoadScene(7); // Beim Auslösen, lädt hier angegebene Szene
    }
}
