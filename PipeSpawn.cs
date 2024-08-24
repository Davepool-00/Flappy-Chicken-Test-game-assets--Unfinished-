using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnSpeed = 2;
    private float timer = 0;
    public float heightoffset = 10;
    // Start is called before the first frame update
    void Start() {
         SpawnPipe(); //!! make a ui for start later 
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnSpeed)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
         SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe(){
        float lowestpointHeight = transform.position.y - heightoffset;
        float highestpointHeight = transform.position.y + heightoffset;


         Instantiate(pipePrefab, new Vector3(transform.position.x, Random.Range(lowestpointHeight, highestpointHeight),0 ), transform.rotation);
    }
}
