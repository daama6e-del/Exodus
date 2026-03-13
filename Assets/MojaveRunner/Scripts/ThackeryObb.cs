using UnityEngine;

public class ThackeryObb : MonoBehaviour
{
    public ParalaxThackeryGame.Layer layer;
    public float breakBoom = -18f;


    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.left * ParalaxThackeryGame.GetSpeed(layer) * Time.deltaTime);
        // Make sure this calculation is frame rate independent (hint: use Time.deltaTime) ohh thats right

        if (transform.position.x < breakBoom)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerHealth.TryDamageTarget(other.gameObject, 1);
    }
}
