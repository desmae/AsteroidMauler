using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float minX, minY, maxX, maxY;
    [SerializeField] public float speed = 0f;
    [SerializeField] public GameObject laser;
    [SerializeField] public GameObject laserSpawner;

    private float timer;
    public float fireRate = 0.25f;
    private Rigidbody2D rBody;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal, vertical;
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        // Debug.Log(horizontal);
        // Debug.Log(vertical);
        rBody.velocity = new Vector2((horizontal * speed), (vertical * speed));


        float newX, newY;

        newX = Mathf.Clamp(rBody.position.x, minX, maxX);
        newY = Mathf.Clamp(rBody.position.y, minY, maxY);

        rBody.position = new Vector2(newX, newY);

        // laser code

        if (Input.GetAxis("Fire1") > 0 && timer > fireRate)
        {

            GameObject gObj;
            gObj = GameObject.Instantiate(laser, laserSpawner.transform.position, laserSpawner.transform.rotation);
            gObj.transform.Rotate(new Vector3(0, 0, 0));

            timer = 0;
        }
        timer += Time.deltaTime * 0.1f;
    }
}
