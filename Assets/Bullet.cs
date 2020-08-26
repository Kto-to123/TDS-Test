using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 1;
    public float speed = 1;

    private void OnEnable()
    {
        EnemyManager.AllEnemiesDefeated += DestroyBullet;
        LevelManager.Restart += DestroyBullet;
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        var enemy = other.GetComponent<IDamageable>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            DestroyBullet();
        }
    }

    void DestroyBullet()
    {
        EnemyManager.AllEnemiesDefeated -= DestroyBullet;
        LevelManager.Restart -= DestroyBullet;
        Destroy(gameObject);
    }
}
