using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_script : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float Flap_str; //!! change this later to set fixed value
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {

        // makes the bird go upward using velocity
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myrigidbody.velocity = Vector2.up * Flap_str;
        }
    }
}
