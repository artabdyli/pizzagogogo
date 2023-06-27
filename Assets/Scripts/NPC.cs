using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //Change with Script. Object
    public string name;
   [SerializeField] private Animator poi;
    private BoxCollider bc;
    private void Start()
    {
        //poi = GetComponentInChildren<Animator>();
        bc = GetComponent<BoxCollider>();
    }
    public void ActivateNPC()
    {
        poi.SetBool("isEnabled", true);
        bc.enabled = true;

    }
    public void DisableNPC()
    {
        poi.SetBool("isEnabled", false);
        bc.enabled = false; 
    }
}
