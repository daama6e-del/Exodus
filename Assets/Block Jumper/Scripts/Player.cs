using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Script should require a Rigidbody2D component
[RequireComponent(typeof(Rigidbody2D))]

public class Player : MonoBehaviour
{
    // TODO: Reference to Rigidbody2D component should have class scope.
    public Rigidbody2D rigidbody;
    // TODO: A float variable to control how high to jump / how much upwards
    public float JumpHeight = 2;
    // force to add. yup

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
        // TODO: On the frame the player presses down the space bar, add an instant upwards
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 forceDirection = transform.up;
            rigidbody.AddForce(forceDirection * JumpHeight, ForceMode2D.Impulse);
        }
        // force to the rigidbody.
    }
}