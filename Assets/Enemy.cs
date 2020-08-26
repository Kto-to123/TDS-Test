using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour, IDamageable
{
    public UnityAction EnemyDefeated;

    public int hp;
    public EnemyManager enemyManager;

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0) Die();
    }

    void Die()
    {
        enemyManager.EnemyDefeated(this);
        EnemyDefeated?.Invoke();
        Destroy(gameObject);
    }
}
