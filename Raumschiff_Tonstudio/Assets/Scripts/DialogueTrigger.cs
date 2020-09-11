using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    //Dieses Skript ist mit der Stele verknüpft, auf der Text ausgegeben werden soll
    public Dialogue dialogue;

    //Bei Betreten des Colliders der Stele wird der Dialog gestartet
    void OnTriggerEnter(Collider other){
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    //Bei Verlassen des Colliders der Stele wird der Dialog beendet
    void OnTriggerExit(Collider other){
        FindObjectOfType<DialogueManager>().EndDialogue();
    }

    //Bei Drücken der Space-Taste wird das nächste Textfeld ausgegeben
    void Update(){
        if(Input.GetKeyDown("space")){
            FindObjectOfType<DialogueManager>().DisplayNextSentence();
        }
    }
    /*public void TriggerDialogue (){
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }*/
}
