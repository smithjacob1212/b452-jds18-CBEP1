using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleJump : MonoBehaviour
{

    Rigidbody rb;
    Collider col;
    [SerializeField] float jumpSpeed = 5;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            if(IsGrounded())
            {
                Vector3 new_vel = rb.velocity;
                new_vel.y = jumpSpeed;
                rb.velocity = new_vel;
            }
        }
    }


    bool IsGrounded()
    {
        float dist = col.bounds.extents.y + 0.05f;
        return Physics.Raycast(transform.position, Vector3.down, dist, 1 + (1 << 7)) ;
    }
}
