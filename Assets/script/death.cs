using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour {
    public playercode player;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<playercode>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            player.Damage(1);
           
        }
    }
}
