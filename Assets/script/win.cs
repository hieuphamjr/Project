using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour {
    public int Levelload = 1;
    public mastergame gm;

    // Use this for initialization
    void Start () {
        gm = GameObject.FindGameObjectWithTag("mastergame").GetComponent<mastergame>();

    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            savescore();
            gm.InputText.text = ("'Liếm để sang màn");
        }
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.L))
            {
                savescore();
                SceneManager.LoadScene(Levelload);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            gm.InputText.text = ("");
        }
    }

    void savescore()
    {
        PlayerPrefs.SetInt("points", gm.points);
    }
}
