using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip g;

    public AudioSource adisrc;

    // Use this for initialization
    void Start()
    {
        g = Resources.Load<AudioClip>("gold");

        adisrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void Playsound(string clip)
    {
        switch (clip)
        {
            case "tien":
                adisrc.clip = g;
                adisrc.PlayOneShot(g, 0.4f);
                break;

        }
    }
}
