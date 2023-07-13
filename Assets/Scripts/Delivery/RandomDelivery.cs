using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDelivery : MonoBehaviour
{
    [Header("NPCs")]
    [SerializeField] private GameObject[] npcs;
    int i = 0;

    public void PickCustomer()
    {
        i = Random.Range(0, npcs.Length);
        npcs[i].GetComponent<NPC>();
    }


}
