using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class otherObjAni : MonoBehaviour
{
   //Dieses Skript startet die Animation, mit der der Krankenwagen durchfährt
	//Die Animation wird erst durch Betreten eines BoxColliders ausgeführt
	private Animator _animator;
    public AudioSource audioData;
    public GameObject ambulance;

	void Start()
	{
        //ruft den Animator auf
		_animator = GameObject.Find("ambulance").GetComponent<Animator>();
        
        
        audioData = GameObject.Find("ambulance").GetComponent<AudioSource>();

	}

    //bei Betreten des Colliders wird folgende Funktion ausgeführt
	void OnTriggerEnter(Collider other)
	{
        //der Parameter open im Animator wird auf true gesetzt, die Animation wird gestartet
        //und die Audiosource aktiviert
		_animator.SetBool("open", true);
        _animator.enabled = true;
	}
    
   void OnTriggerExit(Collider other)
	{
        //der Parameter open im Animator wird auf true gesetzt, die Animation wird beendet
        //und die Audiosource deaktiviert
		_animator.enabled = false;
        audioData.enabled = false;
	}
    
}