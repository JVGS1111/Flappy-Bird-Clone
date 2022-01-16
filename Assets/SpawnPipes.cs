using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public GameObject pipe;
    public float height;
    public float maxTime = 1f;
    private float timer = 0f;


    void Start()
    {
        // SpawnPipesRandowly();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            SpawnPipesRandomly();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    public void SpawnPipesRandomly()
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

        Destroy(newPipe, 10f);

    }
}
