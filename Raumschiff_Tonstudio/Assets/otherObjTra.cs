using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherObjTra : MonoBehaviour
{
   //Dieses Skript startet die Animation, mit der der Zug durchfährt
	//Die Animation wird erst durch Betreten eines BoxColliders ausgeführt
	private Animator _animator;
    public AudioSource audioData;
    public GameObject Train;

	void Start()
	{
        //ruft den Animator auf
		_animator = GameObject.Find("Train").GetComponent<Animator>();
        
        
        audioData = GameObject.Find("Train").GetComponent<AudioSource>();

	}

    //bei Betreten des Colliders wird folgende Funktion ausgeführt
	void OnTriggerEnter(Collider other)
	{
        //der Parameter open im Animator wird auf true gesetzt, die Animation wird gestartet
		_animator.SetBool("open", true);
        _animator.enabled = true;
	}
    
   void OnTriggerExit(Collider other)
	{
        //der Parameter open im Animator wird auf true gesetzt, die Animation wird gestartet
		_animator.enabled = false;
        audioData.enabled = false;
	}
    
}
