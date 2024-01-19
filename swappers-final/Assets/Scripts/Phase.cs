using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase : MonoBehaviour
{
    Rigidbody rb;
    Transform tf;

    public GameObject collisionDetector;

    private bool canPhase = true;

    // Start is called before the first frame update
    void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
        tf = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            if(!canPhase)
            {
                return;
            }


            float one = Input.GetAxis("Horizontal") <= 0 ? -1 : 1;
            Vector3 pos = tf.position;

            Vector3 way = one > 0 ? Vector3.right : Vector3.left;

            RaycastHit hit;

            if (canPhase && Physics.Raycast(tf.position, way, out hit, 3.5f, 1 + (1 << 6))) {
                Collider col = hit.collider;
                if (col.gameObject.layer == 6)
                {
                    
                    return;
                }
                if (col.bounds.extents.x <= 2)
                {
                    pos.x = (col.gameObject.transform.position.x + col.bounds.extents.x * one) + one * 0.75f ;
                    tf.position = pos;
                    StartCoroutine(PhaseReset());
                    
                    return;
                }
                return;
            }

            pos.x += one * 3f;
            tf.position = pos;
            StartCoroutine(PhaseReset());
        }
    }

    IEnumerator PhaseReset()
    {
        canPhase = false;
        yield return new WaitForSeconds(2f);
        canPhase = true;
    }
}
