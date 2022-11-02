﻿using System;
using UnityEngine;

public class GreenBallCollisionManager : BallCollisionManager
{
    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Green Ball Collision Manager Function");

        // Homework: Do something interesting here

        OtherBall.GetComponent<Rigidbody>().AddForce((transform.position - OtherBall.transform.position) * 1000f);

    }
}

