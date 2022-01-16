using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 1f;
    //private float gameTime = 0f;
    void Start()
    {
        //gameTime += Time.deltaTime;
    }


    void Update()
    {
        // gameTime += Time.deltaTime;

        transform.position += Vector3.left * speed * Time.deltaTime;

    }
}
