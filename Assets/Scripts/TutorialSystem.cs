using Cinemachine;
using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class TutorialSystem : MonoBehaviour
{
    [SerializeField] private string[] tutorialText;
    [Header("TextField")]
    [SerializeField] private TMP_Text text;
    private StarterAssetsInputs playerInput;
    public bool isActive = true;
    int i = 0;

    [Header("UiPanels")]
    [SerializeField] private GameObject streetObj;
    [SerializeField] private GameObject deliveryObj;
    [SerializeField] private GameObject tipObj;

    [Header("Points Of Interest")]
    [SerializeField] private GameObject pizzaPlacePOI;
    [SerializeField] private GameObject carPOI;
    [SerializeField] private GameObject playerPOI;
    [SerializeField] private CinemachineVirtualCamera cam;

    private void Start()
    {
        playerInput = GameObject.FindGameObjectWithTag("Player").GetComponent<StarterAssetsInputs>();
        text.text = tutorialText[i];
        i++;
    }
    private void LateUpdate()
    {
        if(isActive && playerInput.click)
        {
            isActive = false;
            StartCoroutine(ChangeText());
            Debug.Log("Clicked!");
            switch(i)
            {
                case 2: streetObj.SetActive(true); break;
                case 3: deliveryObj.SetActive(true); break;
                case 4: tipObj.SetActive(true); break;
                case 6: cam.m_Follow = pizzaPlacePOI.transform; break;
                case 7: cam.m_Follow = carPOI.transform; break;
                case 8: cam.m_Follow= playerPOI.transform; break;
            }
            
        }
    }

    private IEnumerator ChangeText()
    {
        Debug.Log("Clicked!");
        yield return new WaitForSeconds(0.5f);
        if (tutorialText.Length > i -1)
        {
            ++i;
            text.text = tutorialText[i];
            isActive = true;
        }
        else
        {
            isActive = false;
        }
    }


}
