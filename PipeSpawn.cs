using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float alturaPipe;
    public int playerReady = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (playerReady == 1) { 
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipeFuntion();
            timer = 0;
        }
    }
        
    }
    void spawnPipeFuntion()
    {
        float lowestPoint = transform.position.y - alturaPipe;
        float highestPoint = transform.position.y + alturaPipe;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint , highestPoint),0), transform.rotation);
    }
    public void BirdReady()
    {
        playerReady = 1;
    }
}
