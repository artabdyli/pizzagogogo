using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [Header("SettingImages")]
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private Sprite videoPanel;
    [SerializeField] private GameObject videoUI;
    [SerializeField] private Sprite audioPanel;
    [SerializeField] private GameObject audioUI;
    [SerializeField] private Sprite controlPanel;
    [SerializeField] private Image mainPanel;

    [Header("Video Settings")]
    private int i = 0;
    private bool isFullscreen = true;
    [SerializeField] private TMP_Text resText;
    [SerializeField] private GameObject cross;

    [Header("Sound Settings")]
    private bool isMute;
   public void Play()
    {
        SceneManager.LoadScene("TestArea");
    }
   public void Settings()
    {
        settingsPanel.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }

    //SettingsButtons
    public void OpenVideoPanel()
    {
        mainPanel.sprite = videoPanel;
        audioUI.SetActive(false);
        videoUI.SetActive(true);
    }
    public void OpenAudioPanel()
    {
        mainPanel.sprite = audioPanel;
        audioUI.SetActive(true);
        videoUI.SetActive(false);
    }
    public void OpenControlPanel()
    {

        mainPanel.sprite = controlPanel;
        audioUI?.SetActive(false);
        videoUI.SetActive(false);
    }
    public void ApplySettings()
    {
        //TODO
    }
    public void ExitSettings()
    {
        settingsPanel?.SetActive(false);
    }

    //Video Panel
    public void NextResolution()
    {
        i++;
        if(i>3)
        {
            i = 0;
        }
        switch (i)
        {
            case 0: Screen.SetResolution(1920, 1080, isFullscreen); resText.text = "1920 x 1080"; break;
            case 1: Screen.SetResolution(1760, 990, isFullscreen); resText.text = "1760 x 990"; break;
            case 2: Screen.SetResolution(1600, 900, isFullscreen); resText.text = "1600 x 900"; break;
            case 3: Screen.SetResolution(1280, 720, isFullscreen); resText.text = "1280 x 720"; break;
        }
    }

    public void LastResolution()
    {
        i--;
        if (i < 0)
        {
            i = 3;
        }
        switch (i)
        {
            case 0: Screen.SetResolution(1920, 1080, isFullscreen); resText.text = "1920 x 1080"; break;
            case 1: Screen.SetResolution(1760, 990, isFullscreen); resText.text = "1760 x 990"; break;
            case 2: Screen.SetResolution(1600, 900, isFullscreen); resText.text = "1600 x 900"; break;
            case 3: Screen.SetResolution(1280, 720, isFullscreen); resText.text = "1280 x 720"; break;
        }
    }
    public void FullScreenMode()
    {
        if(isFullscreen)
        {
            isFullscreen = false;
            cross.SetActive(false);
            Screen.SetResolution(Screen.width, Screen.height, isFullscreen);
        }
        else
        {
            isFullscreen = true;
            cross.SetActive(true);
            Screen.SetResolution(Screen.width,Screen.height, isFullscreen);
        }
    }
    public void ChangeBrightness(float value)
    {
        Screen.brightness = value;
    }

    //SoundPanel
    public void ChangeMusic(float value)
    {
        //TODO
    }
    public void ChangeSound(float value)
    {
        //TODO
    }
    public void ChangeDialog(float value)
    {
        //TODO
    }
    public void Mute()
    {
        if (isMute)
        {
            //TODO
        }
    }
}
