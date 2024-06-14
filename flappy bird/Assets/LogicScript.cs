using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int PlayerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource dingSound;
    public AudioSource gameOverSound;
    public AudioSource spacePressSound; // Drag your spacebar press sound effect here in the Inspector

    void Update()
    {
        // Check if the spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Play the spacebar press sound effect
            PlaySpacePressSound();
        }
    }

    [ContextMenu("Increase Score")]
    public void addScore(int ScoreToAdd)
    {
        PlayerScore += ScoreToAdd;
        scoreText.text = PlayerScore.ToString();
        PlayDingSound();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        PlayGameOverSound();
    }

    void PlayDingSound()
    {
        if (dingSound != null)
        {
            dingSound.Play();
        }
    }

    void PlayGameOverSound()
    {
        if (gameOverSound != null)
        {
            gameOverSound.Play();
        }
    }

    void PlaySpacePressSound()
    {
        if (spacePressSound != null)
        {
            spacePressSound.Play();
        }
    }
}