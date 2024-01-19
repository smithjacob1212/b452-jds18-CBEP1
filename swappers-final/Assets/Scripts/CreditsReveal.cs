using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsReveal : MonoBehaviour
{

    public Text developer;
    public Text hidden;

    public void OnCollisionEnter(Collision collision)
    {
        print(developer.name + hidden.name);
        developer.gameObject.SetActive(true);
        hidden.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
    }

}
