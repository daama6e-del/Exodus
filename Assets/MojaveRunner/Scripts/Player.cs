using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float JumpHeight = 2;
    public float Speed = 10;
    public bool IsFalling = true;

    void Start()
    {
        if (rigidbody == null) //It sugested to prevent error if it was nulled. But it is not needed because of the RequireComponent component of Rigidbody presnet.
        {
            rigidbody = GetComponent<Rigidbody2D>();
        }
    }

    void Update()
    {
        if (!IsFalling)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("Is reciving Jump Command"); //Debug
                Vector2 forceDirection = transform.up;
                rigidbody.AddForce(forceDirection * JumpHeight, ForceMode2D.Impulse);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("On collision enter"); //Debug
        if (collision.gameObject.CompareTag("Ground")) //The engine does not know what 'other' is
        {
            IsFalling = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        print("On collision exit"); //Debug
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsFalling = true;
        }
    }
    
}