using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed=5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float movex, movez;
        movex = Input.GetAxis("Horizontal");
        movez = Input.GetAxis("Vertical");
        rb.AddForce(movex*speed, 0, movez*speed);
    }
}
