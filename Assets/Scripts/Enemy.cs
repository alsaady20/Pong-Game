using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 8;
    Vector3 targetPos;
    Vector3 playerPos;
    GameObject ballObj;


    void Start()
    {
        ballObj = GameObject.FindGameObjectWithTag("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        if(ballObj != null)
        {
            targetPos = Vector3.Lerp (gameObject.transform.position, ballObj.transform.position, Time.deltaTime * speed);
            playerPos = new Vector3(-20, Mathf.Clamp(targetPos.y, -12.5f, 12.5f), 0);
            gameObject.transform.position = new Vector3(20, targetPos.y, 0);
        }
        else
        {
            ballObj = GameObject.FindGameObjectWithTag("Ball");
        }

    }
}
