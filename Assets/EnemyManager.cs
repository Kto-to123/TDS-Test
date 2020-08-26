using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyManager : MonoBehaviour
{
    public static UnityAction AllEnemiesDefeated;
    public static UnityAction<EnemyManager> IAmEnemyManager;

    public List<Enemy> enemies;

    public Enemy GetСlosestEnemy(Transform player)
    {
        if (enemies.Count == 0) return null;

        Enemy closest = enemies[0];
        float closestDistance = Vector3.Distance(closest.transform.position, player.position);

        foreach (var enemy in enemies)
        {
            float distance = Vector3.Distance(enemy.transform.position, player.position);
            if (distance < closestDistance)
            {
                closest = enemy;
                closestDistance = distance;
            }
        }

        return closest;
    }

    private void OnEnable()
    {
        IAmEnemyManager?.Invoke(this);
    }

    public void EnemyDefeated(Enemy enemy)
    {
        enemies.Remove(enemy);
        if (enemies.Count == 0)
            AllEnemiesDefeated?.Invoke();
    }
}
