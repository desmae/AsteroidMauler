using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        //something collided

        //create explosion
        Instantiate(explosion, transform.position, transform.rotation);
        //delete other object
        Destroy(other.gameObject);
        Destroy(this.gameObject);
        //delete this object
    }
}
