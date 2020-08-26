using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{
    public static UnityAction Restart;
    public static GameObject staticPlayer;

    public GameObject Player;
    GameObject ActiveLevel;
    int activeLevelIndex = 0;
    public GameObject[] levels;

    public void Start()
    {
        staticPlayer = Player;
        ActiveLevel = Instantiate(levels[0]);
    }

    public void NextLevel()
    {
        if (levels.Length == activeLevelIndex + 1)
            activeLevelIndex = 0;
        else
            activeLevelIndex++;

        RestartThisLevel();
    }

    public void RestartThisLevel()
    {
        Destroy(ActiveLevel);
        ActiveLevel = Instantiate(levels[activeLevelIndex]);
        Restart?.Invoke();
    }
}
