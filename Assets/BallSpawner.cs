using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    public GameObject[] dropper;
    public Rigidbody2D ball;
    private int randomDrop;
    private Transform dropPosition;
    private float ballTimer = 0;
    void Update()
    {
        if (ballTimer >= 0)
        {
            ballTimer -= Time.deltaTime;
        }
        if (Input.GetButton("Jump") && ballTimer <= 0)
        {
            randomDrop = Random.Range(1, 5);
            dropPosition = dropper[randomDrop].transform;
            Instantiate(ball, dropPosition.position, dropPosition.rotation);
            Debug.Log(randomDrop);
            ballTimer = 2f;
        }
    }
}
