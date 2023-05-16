using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject ConfirmationPanel;
    public GameObject AboutPanel;

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
    }

    public void AboutClicked()
    {
        ConfirmationPanel.SetActive(false);
        AboutPanel.SetActive(true);
    }

    public void Back()
    {
        ConfirmationPanel.SetActive(false);
        AboutPanel.SetActive(false);
    }
}
