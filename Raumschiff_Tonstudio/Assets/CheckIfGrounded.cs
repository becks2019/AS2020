using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfGrounded : MonoBehaviour
{

  public Collider playerCollider;
  public bool isGrounded; 
  public bool isOnTerrain; //Terrain Boden
  public bool isOnCarpet; //Teppich Boden
  public bool isOnMarmor; //Marmor Boden

  RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
        isGrounded = PlayerGrounded();
        isOnTerrain = CheckOnTerrain();
        isOnCarpet = CheckIfCarpet();
        isOnMarmor = CheckIfMarmor();
    }
    
    //Dieses Skript checkt, ob der Player auf dem Boden steht, indem überprüft wird, ob der Collider des Players den Collider des Terrains/Bodens berührt
    bool PlayerGrounded(){
      return Physics.Raycast (transform.position, Vector3.down, out hit, playerCollider.bounds.extents.y + 0.5f);
    }

    bool CheckOnTerrain(){
        if(hit.collider != null && hit.collider.tag == "Terrain"){
            return true;
        }
        else {
            return false;
        }
    }

    bool CheckIfCarpet(){
        if(hit.collider != null && hit.collider.tag == "TeppichRot"){
            return true;
        }
        else {
            return false;
        }
    }

    bool CheckIfMarmor(){
        if(hit.collider != null && hit.collider.tag == "Marmor"){
            return true;
        }
        else {
            return false;
        }
    }

}