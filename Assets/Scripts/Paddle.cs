using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float paddleSpeed = 1f;
    public Vector3 playerPos = new Vector3(0, 0, 0);

    // Update is called once per frame
    void Update()
    {
        float yPos = gameObject.transform.position.y + (Input.GetAxis("Vertical") * paddleSpeed);
        playerPos = new Vector3(-20, Mathf.Clamp(yPos, -12.5f, 12.5f), 0);
        gameObject.transform.position = playerPos;
    }
}
