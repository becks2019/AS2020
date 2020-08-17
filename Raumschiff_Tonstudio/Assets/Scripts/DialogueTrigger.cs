using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    void OnTriggerEnter(Collider other){
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    void Update(){
        if(Input.GetKeyDown("space")){
            FindObjectOfType<DialogueManager>().DisplayNextSentence();
        }
    }
    /*public void TriggerDialogue (){
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }*/
}
