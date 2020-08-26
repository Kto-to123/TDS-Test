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
    }

    private void OnDisable()
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
