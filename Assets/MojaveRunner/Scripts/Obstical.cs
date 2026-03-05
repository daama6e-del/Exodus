using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // TODO: A public float variable to control how fast the obstacle moves across the screen
    public float zoooom = 5f;
    
    // TODO: A public float variable to control how far the object should go before being destroyed offscreen.
    public float breakBoom = -18f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: Move the obstacle to the left at a constant rate. 
        Vector2 forceDirection = -transform.right;
        transform.Translate(forceDirection * zoooom * Time.deltaTime);
        // Make sure this calculation is frame rate independent (hint: use Time.deltaTime) ohh thats right
        

        // TODO: If the obstalce is off screen to the left, destroy this GameObject (hint: Destroy(gameObject))
        if (transform.position.x < breakBoom)
        {
            Destroy(gameObject);
        }
        
    }
}