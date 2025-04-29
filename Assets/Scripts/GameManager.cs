using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int playerLives = 3;
    public float timeLeft = 60f;

    public TMP_Text scoreText;
    public TMP_Text timerText;

    public GameObject gameOverText;
    public GameObject restartButton;

    public Image life1Image;
    public Image life2Image;
    public Image life3Image;

    void Start()
    {
        UpdateScoreText();
        UpdateTimerText();
        UpdateLivesIcons();

        gameOverText.SetActive(false);
        restartButton.SetActive(false);
        Time.timeScale = 1;
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        UpdateTimerText();

        if (timeLeft <= 0)
        {
            GameOver();
        }
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    void UpdateTimerText()
    {
        timerText.text = "Time: " + Mathf.CeilToInt(timeLeft);
    }

    public void PlayerHit()
    {
        playerLives--;
        UpdateLivesIcons();

        if (playerLives <= 0)
        {
            GameOver();
        }
    }

    void UpdateLivesIcons()
    {
        if (playerLives < 3) life3Image.enabled = false;
        if (playerLives < 2) life2Image.enabled = false;
        if (playerLives < 1) life1Image.enabled = false;
    }

    public void AddTime(float extraTime)
    {
        timeLeft += extraTime;
    }

    public void GameOver()
    {
        gameOverText.SetActive(true);
        restartButton.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
