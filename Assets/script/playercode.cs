using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class playercode : MonoBehaviour {
    public float speed = 50f, maxspeed = 3, jumPow = 220f;
    public bool grounded = true, xtrue = true;

    public Animator anim;
    public Rigidbody2D r2;
    public int blood;
    public int maxblood = 1;
    public mastergame gm;
    public soundgold sound;


    // Use this for initialization
    void Start () {
        r2 = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        gm = GameObject.FindGameObjectWithTag("mastergame").GetComponent<mastergame>();
        maxblood = blood;
        sound = GameObject.FindGameObjectWithTag("sounds").GetComponent<soundgold>();


    }
	
	// Update is called once per frame
	void Update () {
        anim.SetBool("Grounded", grounded);
        anim.SetFloat("Speed", Mathf.Abs(r2.velocity.x));

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
            {
                grounded = false;
                r2.AddForce(Vector2.up * jumPow);
            }
        }
		
	}
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        r2.AddForce((Vector2.right) * speed * h);

        if(r2.velocity.x > maxspeed)
        {
            r2.velocity = new Vector2(maxspeed, r2.velocity.y);
        }

        if (r2.velocity.x < -maxspeed)
        {
            r2.velocity = new Vector2(-maxspeed, r2.velocity.y);
        }
        if(h>0 && !xtrue)
        {
            quay();
        }
        if(h<0 && xtrue)
        {
            quay();
        }
        if (grounded)
        {
            r2.velocity = new Vector2(r2.velocity.x * 0.8f, r2.velocity.y);
        }
        if (maxblood <= 0)
        {
            Death();
        }
    }
    public void quay()
    {
        xtrue = !xtrue;
        Vector3 Scale;
        Scale = transform.localScale;
        Scale.x *= -1;
        transform.localScale = Scale;

    }
    public void Death()
    {
        sound.Playsound("cuoi");
        Thread.Sleep(5000);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gm.dea += 1;
        PlayerPrefs.SetInt("dea", gm.dea);
        //PlayerPrefs.SetInt("dea", 0);
    }
    public void Damage(int damage)
    {
        maxblood -= damage;
        

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("tien"))
        {
            sound.Playsound("tien");
            Destroy(col.gameObject);
            gm.points += 1;
        }
        if (col.CompareTag("bienmat"))
        {
            Destroy(col.gameObject);
        }


    }

}
