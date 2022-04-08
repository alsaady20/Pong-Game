using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBall : MonoBehaviour
{
    public int ballVel = 500;

    public Rigidbody rb;

    private void Awake()
    {
        rb.velocity = new Vector3(ballVel, ballVel, 0);
    }
}
