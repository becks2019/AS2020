using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public CheckIfGrounded checkIfGrounded;

    public AudioSource audioSource;

    public AudioClip[] stoneClips;
    public AudioClip[] dirtClips;
    public AudioClip[] carpetClips;
    AudioClip previousClip;

    CharacterController character;
    float currentSpeed;
    bool walking;
    float distanceCovered;
    public float modifier = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        character = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        currentSpeed = GetPlayerSpeed();
        walking = CheckIfWalking();

        if(walking){
           // distanceCovered += (currentSpeed * Time.deltaTime) * modifier;

            //if(distanceCovered > 1){
                TriggerNextClip();
              //  distanceCovered = 0;
            //}
        }
    }

    float GetPlayerSpeed(){
        float speed = character.velocity.magnitude;
        return speed;
    }

    bool CheckIfWalking(){
        if(currentSpeed > 0 && checkIfGrounded.isGrounded){
            return true;
        } else {
            return false;
        }
    }

    AudioClip GetClipFromArray(AudioClip[] clipArray){
        int attempts = 3;
        AudioClip selectedClip = clipArray [Random.Range (0, clipArray.Length - 1)];

        while(selectedClip == previousClip && attempts > 0){
            selectedClip = clipArray [Random.Range (0, clipArray.Length -1)];
            attempts--;
        }

        previousClip = selectedClip;
        return selectedClip;
    }

    void TriggerNextClip(){
        audioSource.pitch = Random.Range(0.9f, 1.1f);
        audioSource.volume = Random.Range(0.8f, 1);

        if(checkIfGrounded.isOnTerrain){
            audioSource.PlayOneShot (GetClipFromArray (dirtClips), 1);
        } else if(checkIfGrounded.isOnCarpet){
            audioSource.PlayOneShot (GetClipFromArray (carpetClips), 1);
        } else if(checkIfGrounded.isOnMarmor){
            audioSource.PlayOneShot (GetClipFromArray (stoneClips), 1);
        }
    }

}
