using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject ConfirmationPanel;
    public GameObject AboutPanel;
    public GameObject SettingPanel;
    public AudioMixer audioMixer;
    public Dropdown resolutionDropdown;

    Resolution[] resolutions;

    void Start()
    {
        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for(int i = 0; i < resolutions.Length; i++) 
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width ==  Screen.currentResolution.width && resolutions[i].height ==  Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetResolution (int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void exit()
    {
        Application.Quit();
        Debug.Log("Keluar~~");
    }

    public void play(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }

    public void ConfClicked()
    {
        ConfirmationPanel.SetActive(true);
        AboutPanel.SetActive(false);
        SettingPanel.SetActive(false);
    }

    public void AboutClicked()
    {
        ConfirmationPanel.SetActive(false);
        AboutPanel.SetActive(true);
        SettingPanel.SetActive(false);
    }

    public void SettingClicked()
    {
        ConfirmationPanel.SetActive(false);
        AboutPanel.SetActive(false);
        SettingPanel.SetActive(true);
    }

    public void Back()
    {
        ConfirmationPanel.SetActive(false);
        AboutPanel.SetActive(false);
        SettingPanel.SetActive(false);
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
