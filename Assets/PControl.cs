using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PControl : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2d;
    public KeyCode moveUp;
    public KeyCode moveDown;
    public float speed;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Movement()
    {
        var vel = rb2d.velocity;
        if(Input.GetKey(moveUp)) vel.y = speed;
        else if(Input.GetKey(moveDown)) vel.y = -speed;
        else vel.y= 0;
        rb2d.velocity = vel;
    }

    void Update()
    {
        Movement();
    }
}
