using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public LevelManager levelManager;
    public GameObject gameWinPanel;
    public GameObject gameOverPanel;

    private void Start()
    {
        EnemyManager.AllEnemiesDefeated += GameWin;
        PlayerHealth.PlayerDefeated += GameOver;
    }

    void GameWin()
    {
        gameWinPanel.SetActive(true);
    }

    public void NextLevel()
    {
        levelManager.NextLevel();
        gameWinPanel.SetActive(false);
    }

    void GameOver()
    {
        gameOverPanel.SetActive(true);
    }

    public void Restart()
    {
        levelManager.RestartThisLevel();
        gameOverPanel.SetActive(false);
    }
}
