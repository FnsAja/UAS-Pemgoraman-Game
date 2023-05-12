using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    int score = 0;
    int score1 = 0;

    void OnTriggerEnter(Collider objek)
    {
        if (objek.gameObject.tag == "Organik")
        {
            Destroy(objek.gameObject);
            score += 1;
            GameObject.Find("Collect Sound").GetComponent<AudioSource>().Play();
        }
        if (objek.gameObject.tag == "NonOrganik")
        {
            Destroy(objek.gameObject);
            score1 += 1;
            GameObject.Find("Collect Sound").GetComponent<AudioSource>().Play();
        }
    }
}
