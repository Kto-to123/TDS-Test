using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyView : MonoBehaviour
{
    public GameObject target;
    public Transform view;

    private void OnEnable()
    {
        target = LevelManager.staticPlayer;
    }

    private void FixedUpdate()
    {
        if (target != null)
            view.LookAt(target.transform);
    }
}
