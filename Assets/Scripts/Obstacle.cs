using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour
{

    public Vector2 velocity = new Vector2(-4, 0);
    public float range = 1f;
    Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = velocity;
        //transform.position = new Vector3(transform.position.x + range * Random.value, transform.position.y - range * Random.value, transform.position.z);

    }

    // Update is called once per frame
    void Update()
    { 

    }
}

