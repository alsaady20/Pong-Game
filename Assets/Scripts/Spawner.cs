using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{

    int randX;
    int randY;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Spawn();
        }
    }
        void CreateRandomPosition()
        {
            randX = Random.Range(-8, 8);
            randY = Random.Range(-4, 4);
        }

        void Spawn()
        {
            CreateRandomPosition();
            Instantiate(ball, new Vector3(randX, randY, 0), Quaternion.identity);
        }
}
