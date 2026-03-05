using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Script should require a Rigidbody2D component
[RequireComponent(typeof(Rigidbody2D))]

public class Player : MonoBehaviour
{
    // TODO: Reference to Rigidbody2D component should have class scope.
    public Rigidbody2D rigidbody;
    public float JumpHeight = 2;
    public float Speed = 10;
    public bool IsFalling = true;

    // Start is called before the first frame update
    void Start()
    {
        // TODO: Use GetComponent to get a reference to attached Rigidbody2D
        if (rigidbody == null) //It sugested to prevent error if it was nulled. But it is not needed because of the RequireComponent component of Rigidbody presnet.
        {
            rigidbody = GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsFalling)
        {
            // TODO: On the frame the player presses down the space bar, add an instant upwards
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Vector2 forceDirection = transform.up;
                rigidbody.AddForce(forceDirection * JumpHeight, ForceMode2D.Impulse);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("On collision enter");
        if (collision.gameObject.CompareTag("Ground")) //The engine does not know what 'other' is
        {
            IsFalling = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        print("On collision exit");
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsFalling = true;
        }
    }
}