using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour
{
    [SerializeField] public float maxSpeed = 100;
    [SerializeField] public float minSpeed = -100;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().angularVelocity = Random.value * 100;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
