using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movescreen : MonoBehaviour
{
    public float  speed = 5;
    public float deadzone = -9;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left *  speed) * Time.deltaTime;

        if ( transform.position.x  < deadzone ){
            Destroy(gameObject);
        }
    }
}
