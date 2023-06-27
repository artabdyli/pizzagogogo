using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverPizza : MonoBehaviour
{
    private DeliverySystem deliverySystem;

    private void Start()
    {
        deliverySystem = GameObject.FindGameObjectWithTag("Player").GetComponent<DeliverySystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"));
        {
            deliverySystem.DeliverPizza();
        }
    }
}
