using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text textScore;
    [SerializeField] GameObject panelGameStart;
    [SerializeField] GameObject panelGameOver;

    private int score = 0;

    private void Start()
    {
        Time.timeScale = 0;
        panelGameStart.SetActive(true);
        panelGameOver.SetActive(false);
    }

    private void OnEnable()
    {
        Scoring.OnAddScore += HandleOnScoreAdd;
        Pipe.OnHitPipe += HandleOnHitPipe;
    }

    private void OnDisable()
    {
        Scoring.OnAddScore -= HandleOnScoreAdd;
        Pipe.OnHitPipe -= HandleOnHitPipe;
    }

    private void HandleOnHitPipe()
    {
        GameOver();
    }

    private void HandleOnScoreAdd()
    {
        score++;
        textScore.text = score.ToString();
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        panelGameStart.SetActive(false);
    }

    private void GameOver()
    {
        Time.timeScale = 0;
        panelGameOver.SetActive(true);
    }

    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
