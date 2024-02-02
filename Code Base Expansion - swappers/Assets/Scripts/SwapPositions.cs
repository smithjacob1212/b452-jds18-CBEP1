using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapPositions : MonoBehaviour
{
    Transform circleTf;
    Transform squareTf;

    Rigidbody crb;
    Rigidbody srb;

    // Start is called before the first frame update
    void Awake()
    {
        circleTf = GameObject.Find("Circle").GetComponent<Transform>();
        squareTf = GameObject.Find("Square").GetComponent<Transform>();

        crb = GameObject.Find("Circle").GetComponent<Rigidbody>();
        srb = GameObject.Find("Square").GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            swap();
        }
    }

    public void swap()
    {
        circleTf = GameObject.Find("Circle").GetComponent<Transform>();
        squareTf = GameObject.Find("Square").GetComponent<Transform>();

        crb = GameObject.Find("Circle").GetComponent<Rigidbody>();
        srb = GameObject.Find("Square").GetComponent<Rigidbody>();

        Vector3 temp = circleTf.position;
        circleTf.position = squareTf.position;
        squareTf.position = temp;

        temp = crb.velocity;
        crb.velocity = srb.velocity;
        srb.velocity = temp;
    }
}
