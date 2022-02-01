using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] GameObject shot;
    public GameObject gunBarrel;

    public float speedX = 15;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-speedX, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speedX, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(shot, gunBarrel.transform.position, gunBarrel.transform.rotation);
        }
    }
}
