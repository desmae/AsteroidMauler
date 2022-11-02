using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Mover : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }
    // test for Git
    // Update is called once per frame
    void Update()
    {
        
        rb.velocity = new Vector2 (speed, rb.velocity.y);
    }
}
