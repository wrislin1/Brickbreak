using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float maxSpeed = 200f;
    public Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body.velocity = new Vector2(4f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        if (body.velocity.magnitude > maxSpeed)
        {
            body.velocity = body.velocity.normalized * maxSpeed;
        }
    }
}
