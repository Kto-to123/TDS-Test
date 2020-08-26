using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bullet;
    public float delay;

    Coroutine coroutine;

    private void Start()
    {
        LevelManager.Restart += Restart;
        EnemyManager.AllEnemiesDefeated += StopShooting;
        PlayerHealth.PlayerDefeated += StopShooting;

        coroutine = StartCoroutine(Shooting());
    }

    private void Restart()
    {
        coroutine = StartCoroutine(Shooting());
    }

    void StopShooting()
    {
        StopCoroutine(coroutine);
    }

    IEnumerator Shooting()
    {
        var seconds = new WaitForSeconds(delay);

        while (true)
        {
            yield return seconds;
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
