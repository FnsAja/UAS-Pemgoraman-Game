using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemAnimation : MonoBehaviour
{
    public float amp;
    public float freq;
    Vector3 initStart;

    void Start()
    {
        initStart = transform.position;
    }

    void Update()
    {
        transform.position = new Vector3(initStart.x, Mathf.Sin(Time.time * freq) * amp + initStart.y, initStart.z);
    }
}
