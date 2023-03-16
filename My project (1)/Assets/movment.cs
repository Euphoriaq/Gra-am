using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour
{
    public Joystick Joystick;
    public float speed;
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        if (Joystick.joystickVec.y != 0)
        {
            rb.velocity = new Vector2(Joystick.joystickVec.x * speed, Joystick.joystickVec.y * speed);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }

}