using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverySystem : MonoBehaviour
{
    [Header("PizzaGameObject")]
    public GameObject pizza;
    [Header("LeftHand")]
    [SerializeField] private Transform handTransform;
    [Header("NPCs")]
    [SerializeField] private GameObject[] npcs;
    private NPC npcScript;
    int i = 0;
    public bool isDelivering = false;

    public void PizzaSpawn()
    {
        if (!isDelivering)
        {
            Debug.Log("Pizza Time!");
            pizza.SetActive(true);
            handTransform.localPosition = new Vector3(31f, 0.76f, 35.53f);
            handTransform.localRotation = Quaternion.Euler(new Vector3(285f, 334f, 205f));
            isDelivering = true;
            PickDelivery();

            isDelivering = true;
        }
    }

    public void DeliverPizza()
    {
        if (isDelivering)
        {
            Debug.Log("Pizza Delivered");
            pizza.SetActive(false);
            handTransform.localPosition = new Vector3(30.77f, -0.22f, 35.25f);
            handTransform.localRotation = Quaternion.Euler(new Vector3(29.24f, 116.25f, 166.33f));
            
            npcScript.DisableNPC();

            isDelivering = false;
        }
    }
    public void PickDelivery()
    {
        i = Random.Range(0, npcs.Length);
        npcScript = npcs[i].GetComponent<NPC>();
        Debug.Log("Delivery to " + npcScript.name);
        npcScript.ActivateNPC();
    }

}
