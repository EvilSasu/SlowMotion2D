using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.5f;
    public SlowMotionController slowMotion;
    public GameObject bloodPE;
    Rigidbody2D rb;
    bool stopGame = false;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!stopGame)
            SlowWhenDontMove();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            stopGame = true;
            Instantiate(bloodPE, transform.position, Quaternion.identity);
            slowMotion.DoNormalTime();
            Destroy(this.gameObject);
        }
            
    }

    void SlowWhenMove()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, 0f);
            slowMotion.DoSlowmotion();
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, 0f);
            slowMotion.DoSlowmotion();
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0f, speed);
            slowMotion.DoSlowmotion();
        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.W))
            slowMotion.DoNormalTime();
    }

    void SlowWhenDontMove()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Input.anyKey)
        {
            rb.velocity *= 3f;
            slowMotion.DoNormalTime();
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity += new Vector2(-speed, 0f);
            slowMotion.DoNormalTime();
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity += new Vector2(speed, 0f);
            slowMotion.DoNormalTime();
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity += new Vector2(0f, speed);
            slowMotion.DoNormalTime();
        }
        
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.W))
        {
            slowMotion.DoSlowmotion();
            rb.velocity = Vector2.zero;
        }   
    }
}
