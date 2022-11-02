using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class RedBallCollisionManager : BallCollisionManager
{
    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Red Ball Collision Manager Function");

        // Homework: Do something interesting here

        gameObject.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);

    }
}

