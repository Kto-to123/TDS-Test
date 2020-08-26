using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    public GameObject bullet;
    public float delay;

    Coroutine coroutine;

    private void OnEnable()
    {
        coroutine = StartCoroutine(Shooting());
        PlayerHealth.PlayerDefeated += StopCoroutine;
    }

    void StopCoroutine()
    {
        StopCoroutine(coroutine);
    }

    private void OnDisable()
    {
        PlayerHealth.PlayerDefeated -= StopCoroutine;
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
