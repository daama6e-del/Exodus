using UnityEngine;

// ToDo: This script requires the use of three components:
// Animator, Player, and Rigidbody2D
// Use the RequireComponent attribute to make sure the GameObject this script is attached to has these components.
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Player))]
public class PlayerAnimation : MonoBehaviour
{
    // ToDo: This script needs a reference variable for each component:
    public Animator TheAnimator;
    public Rigidbody2D TheRigidbody2D;
    public Player ThePlayer;
    public GameObject particlePrefab;
    // Start is called before the first frame update
    void Start()
    {
        // ToDo: Get a reference to each component using GetComponent
        TheAnimator = GetComponent<Animator>();
        TheRigidbody2D = GetComponent<Rigidbody2D>();
        ThePlayer = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        // ToDo: Set the animator bool parameter "Falling" to the value of player.isFalling.
        TheAnimator.SetBool("Falling", ThePlayer.IsFalling);


        // ToDo: Set the animator float parameter "YVelocity" to the value of rigidbody2D.velocity.y
        TheAnimator.SetFloat("YVelocity", TheRigidbody2D.velocity.y);
    }

    public void Smoke()
    {
        Instantiate(particlePrefab, transform.position, Quaternion.identity);
    }
} 