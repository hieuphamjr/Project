using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runGround : MonoBehaviour {

    public float speed = 0.1f, changeDirection = -1;
    Vector3 Move;
    // Use this for initialization
    void Start ()
    {
        Move = this.transform.position;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Move.x += speed;
        this.transform.position = Move;
		
	}
    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            speed *= changeDirection;
        }
    }
}
