using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundgold : MonoBehaviour {
    public AudioClip g,c;

    public AudioSource adisrc;
    // Use this for initialization
    void Start () {
        g = Resources.Load<AudioClip>("gold");
        c = Resources.Load<AudioClip>("cuoi");

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
            case "cuoi":
                adisrc.clip = c;
                adisrc.PlayOneShot(c, 0.6f);
                break;

        }
    }
}
