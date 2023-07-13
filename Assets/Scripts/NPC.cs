using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public NPCSO npcData;
   [SerializeField] private Animator poi;
    private BoxCollider bc;
    private void Start()
    {
        //poi = GetComponentInChildren<Animator>();
        bc = GetComponent<BoxCollider>();
    }
    public void ActivateNPC()
    {
        bc.enabled = true;
        poi.SetBool("isEnabled", true);
        

    }
    public void DisableNPC()
    {
        poi.SetBool("isEnabled", false);
        bc.enabled = false; 
    }
}
