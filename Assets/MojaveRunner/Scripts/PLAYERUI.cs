using System.Threading;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Image[] heartImages;
    public const string F0 = "F0";
    int health = 0;

    public float DistanceScore = 0f;
    public float Multiplier = 5f;
    public float timer = 0f;
    public Text scoreText;

    void Awake()
    {
        // ToDo: Use FindObjectOfType of find a Health script in the scene.

        playerHealth = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!playerHealth) return;

        if (health != playerHealth.healthAmount)
        {
            UpdateHealth();
            print("duke!!!!!!!!!!"); //debugger
        }

        //UI score tracker here

        DistanceScore += Time.deltaTime * Multiplier;

        if (timer >= 1f)
        {
            DistanceScore++;
            timer = 0f;
        }
    }

    // This function will be used to regularly update the hearts on screen to match how much health the player has.
    void UpdateHealth()
    {
        health = playerHealth.healthAmount;

        // ToDo: Create a for loop that will loop through the heart images array.
        /*
            For each iteration(i), if the current value of i, is less than health, 
            set that heart to be enabled (heartImages[i].enabled = true).
            Otherwise, set that heart to be disabled (heartImages[i].enabled = false).
        */
        for (int i = 0; i < heartImages.Length; i++)
        {
            if (i < health)
            {
                heartImages[i].enabled = true;
                print("heartianian"); //debugger
            }
            else
            {
                heartImages[i].enabled = false;
                print("no heartianian"); //debugger
            }
        }
    }
}