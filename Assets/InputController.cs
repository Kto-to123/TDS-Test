using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public Joystick joystick;

    public float GetHorizontal()
    {
        var key = Input.GetAxis("Horizontal");
        var joy = joystick.Horizontal;
        return joy != 0 ? joy : key;
    }

    public float GetVertical()
    {
        var key = Input.GetAxis("Vertical");
        var joy = joystick.Vertical;
        return joy != 0 ? joy : key;
    }
}
