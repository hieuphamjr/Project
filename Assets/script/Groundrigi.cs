﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundrigi : MonoBehaviour {
    public Rigidbody2D r2;
    public float timedelay = 2;

	// Use this for initialization
	void Start () {
        r2 = gameObject.GetComponent<Rigidbody2D>();
		
	}

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            StartCoroutine(fall());
        }
    }

    IEnumerator fall()
    {
        yield return new WaitForSeconds(timedelay);
        r2.bodyType = RigidbodyType2D.Dynamic;
        yield return 0;

    }

    // Update is called once per frame
    void Update () {
		
	}
}
