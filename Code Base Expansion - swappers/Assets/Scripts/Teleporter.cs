using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField] float x = 0;
    [SerializeField] float y = 0;

    void OnTriggerEnter(Collider Col)
    {
        Col.transform.position = new Vector3 (x,y,0);
    }
}
