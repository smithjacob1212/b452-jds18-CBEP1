using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rb;

    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 new_vel = rb.velocity;
        new_vel.x = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new_vel;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "goal")
        {
            GameControl.Instance.IncrementLevel();
        }
    }
}
