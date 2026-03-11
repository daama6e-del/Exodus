using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public float timer = 0f;
    public int highScore = 0 ;
    public int DistanceScore = 0;
    public float Multiplier = 5f;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    void OnDestroy()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime * Multiplier;

        if (timer >= 1f)
        {
            DistanceScore++;
            scoreText.text = "Score: " + DistanceScore.ToString();
            timer = 0f;

            if (DistanceScore > highScore) highScore = DistanceScore;
        }
    }
}
