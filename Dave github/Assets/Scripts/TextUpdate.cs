using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TextUpdate : MonoBehaviour
{
    private int score;
    private int lives;

    public Text livesText;
    public Text scoreText;

    void Update()
    {
        AdjustScore();
        SetText();
    }

    void SetText()
    {
        livesText.text = "Lives" + lives.ToString();
        scoreText.text = "Score" + score.ToString();
    }

    void AdjustScore()
    {
        score = GameManager.manager.score;
        lives = GameManager.manager.lives;
    }
}
