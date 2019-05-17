using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour {
    public playercode player;


	// Use this for initialization
	void Start () {
        player = gameObject.GetComponentInParent<playercode>();

	}
    void Update()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate () {
		
	}
    void OnTriggerEnter2D (Collider2D collision)
    {
        player.grounded = true;
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        player.grounded = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        player.grounded = false;
    }
}
