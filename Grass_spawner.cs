using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass_spawner : MonoBehaviour
{
    public GameObject grassPrefab;
    public float spawnSpeed = 2;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        SpawnGrass(); //!! make a ui for start later
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
            SpawnGrass();
            timer = 0;
        }
    }

    void SpawnGrass()
    {
        Instantiate(grassPrefab, transform.position, transform.rotation);
    }
}
 