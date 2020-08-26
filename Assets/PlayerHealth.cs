using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour, IDamageable
{
    public static UnityAction PlayerDefeated;

    public int hp;

    private void Start()
    {
        LevelManager.Restart += SetStartHP;
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0) GameOver();
    }

    public void SetStartHP()
    {
        hp = 6;
    }

    void GameOver()
    {
        PlayerDefeated?.Invoke();
    }
}
