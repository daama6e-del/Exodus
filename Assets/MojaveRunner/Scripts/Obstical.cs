using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Parallax.Layer layer;
    public float breakBoom = -18f;


    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.left * Parallax.GetSpeed(layer) * Time.deltaTime);
        // Make sure this calculation is frame rate independent (hint: use Time.deltaTime) ohh thats right

        if (transform.position.x < breakBoom)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerHealth.TryDamageTarget(other.gameObject, 1);
    }
}