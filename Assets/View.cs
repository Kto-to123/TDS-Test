using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{
    EnemyManager enemyManager;
    public Transform view;
    Enemy enemy;

    private void Start()
    {
        EnemyManager.IAmEnemyManager += ChangeEnemyManager;
    }

    void ChangeEnemyManager(EnemyManager newManager)
    {
        enemyManager = newManager;
        ChangeEnemy();
    }

    void ChangeEnemy()
    {
        enemy = enemyManager.GetСlosestEnemy(view);
        if (enemy != null) enemy.EnemyDefeated += ChangeEnemy;
    }

    private void FixedUpdate()
    {
        if (enemy != null)
            view.LookAt(enemy.transform);
    }
}
