using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed=5;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        float movex, movez;
        movex = Input.GetAxis("Horizontal");
        movez = Input.GetAxis("Vertical");
        rb.AddForce(movex*speed, 0, movez*speed);
        
    }
    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.gameObject.tag == "enemy") {
            panel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
