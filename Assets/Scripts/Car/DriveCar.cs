using StarterAssets;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class DriveCar : MonoBehaviour
{
    private StarterAssetsInputs playerInput;
    private StarterAssetsInputs input;
    [SerializeField] private GameObject player;
    private CarController carController;
    private PlayerInput carInput;
    [SerializeField] private GameObject carFollowCam;
    private NavigationSystem navigationSystem;


    private void Start()
    {
        carController = GetComponent<CarController>();
        input = GetComponent<StarterAssetsInputs>();
        carInput = GetComponent<PlayerInput>();
        navigationSystem = GetComponent<NavigationSystem>();
        playerInput = GameObject.FindGameObjectWithTag("Player").GetComponent<StarterAssetsInputs>();
    }
    private void Update()
    {
        if(input.drive && carController.enabled)
        {
            input.drive = false;
            GetOut();
            
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player") && playerInput.drive)
        {
            playerInput.drive = false;
            Debug.Log("Get in the Car");
            GetIn();
        }
    }

    private void GetIn()
    {
        player.SetActive(false);
        carController.enabled = true;
        carInput.enabled = true;
        navigationSystem.enabled = true;
        carFollowCam.SetActive(true);

    }

    private void GetOut()
    {
        carController.enabled = false;
        carInput.enabled = false;
        navigationSystem.enabled = false;
        carFollowCam.SetActive(false);
        player.transform.position = new Vector3(this.transform.position.x + 2, this.transform.position.y, this.transform.position.z);
        player.SetActive(true);
    }
}
