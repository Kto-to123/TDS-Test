using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.1f;
    public InputController inputController;
    bool play;

    private void Start()
    {
        LevelManager.Restart += Restart;
        EnemyManager.AllEnemiesDefeated += Stop;
        PlayerHealth.PlayerDefeated += Stop;

        play = true;
    }

    private void Stop()
    {
        play = false;
    }

    void Restart()
    {
        transform.position = Vector3.zero;
        play = true;
    }

    private void FixedUpdate()
    {
        if (play)
        {
            Vector3 move = new Vector3(inputController.GetHorizontal() * speed, 0, inputController.GetVertical() * speed);
            transform.Translate(move);
        }
    }
}
