using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mastergame : MonoBehaviour {
    public int points = 0;
    public int dea = 0;
    public Text deathtext;
    public Text pointstext;
    public Text InputText;
	// Use this for initialization
	void Start () {
       

    }
	
	// Update is called once per frame
	void Update () {
        pointstext.text = ("LoL.Gold: " + points);
        deathtext.text = ("Số lần bạn đã ngu: " + PlayerPrefs.GetInt("dea"));
        



    }
}
