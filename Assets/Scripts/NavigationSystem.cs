using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NavigationSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text streetName;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Road"))
        {
            streetName.text = other.gameObject.name;
        }
    }
}
