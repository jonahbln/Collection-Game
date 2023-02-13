using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float JumpAmount = 3f;
    Rigidbody rb;
    AudioSource jumpSound;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (!LevelManager.gameOver)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 forceVector = new Vector3(moveHorizontal, 0.0f, moveVertical);


            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                forceVector *= 2;
            }

            rb.AddForce(forceVector * speed);

            if (Input.GetButton("Jump"))
            {
                if (transform.position.y <= 1.1f)
                {
                    rb.AddForce(0f, JumpAmount, 0f, ForceMode.Impulse);
                    jumpSound.Play();
                }
            }
        } else
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
