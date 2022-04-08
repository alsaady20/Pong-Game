using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMesh currSco;
	public GameObject ballPref;
	public Transform paddleObj;

	private GameObject ball;
	private int score;

    // Update is called once per frame
    void Update()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
        currSco.text = "" +score;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
    
    {
            score++;
            Destroy(ball);
            (Instantiate(ballPref, new Vector3(paddleObj.transform.position.x + 2, paddleObj.transform.position.y, 0), Quaternion.identity) as GameObject).transform.parent = paddleObj;
        }

    }
    }
