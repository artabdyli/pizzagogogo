using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerData : MonoBehaviour
{
    public int points;
   
    private void Update()
    {
        if(points <= 0) {

            SceneManager.LoadScene("LooseScene");
        }
    }
}
