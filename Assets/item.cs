using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class item : MonoBehaviour
{
    int organik = 0;
    int nonOrganik = 0;
    int score = 0;
    int uang = 0;
    public GameObject WinPanel, PausePanel, LosePanel, StartPanel;
    public Text Skor, Uang;
    public Text SkorWin, SkorLose;

    void Update()
    {
        if (score >= 10 || uang >= 12000)
        {
            WinPanel.SetActive(true);
            SkorWin.text = "SELAMAT KAMU MENANG\n\nSkor : " + score.ToString() + "\nUang : Rp" + uang.ToString();
        }

        // Kondisi Kalah
        //if()
        //{
        //  LosePanel.SetActive(true);]
        //  SkorLose.text = "MAAF KAMU KALAH\n\nSkor : " + score.ToString() + "\nUang : Rp" + uang.ToString();
        //}

        if (Input.GetKey(KeyCode.Escape))
        {
            PausePanel.SetActive(true);
        }
    }

    public void Back()
    {
        PausePanel.SetActive(false);
        StartPanel.SetActive(false);
    }

    public void play(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }

    void OnTriggerEnter(Collider objek)
    {
        if (objek.gameObject.tag == "Organik")
        {
            Destroy(objek.gameObject);
            score += 1;
            organik += 1;
            uang += 1000;
            Skor.text = "Sampah : " + score.ToString();
            Uang.text = "Uang : Rp" + uang.ToString();
            GameObject.Find("Collect Sound").GetComponent<AudioSource>().Play();
        }
        if (objek.gameObject.tag == "NonOrganik")
        {
            Destroy(objek.gameObject);
            score += 1;
            nonOrganik += 1;
            uang += 1500;
            Skor.text = "Sampah : " + score.ToString();
            Uang.text = "Uang : Rp" + uang.ToString();
            GameObject.Find("Collect Sound").GetComponent<AudioSource>().Play();
        }
    }
}
