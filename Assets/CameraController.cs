using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    Vector3 CameraPos;

    private void Start()
    {
        CameraPos = transform.position - player.position;
    }

    void Update()
    {
        transform.position = player.position + CameraPos;
    }
}
