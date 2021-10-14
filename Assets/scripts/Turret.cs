using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Turret : MonoBehaviour
{
    private bool Realoaded;
    // Start is called before the first frame update
    void Start()
    {
        Realoaded = false;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "enemy" && Realoaded == false)
        {
            Destroy(GameObject.FindWithTag("enemy"));
            Realoaded = true;
            Invoke("Reload",2);
        }
    }

    void Reload()
    {
        Realoaded = false;
    }
}
