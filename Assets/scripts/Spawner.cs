using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform enemyNormal;
    public bool Canspawn;
    // Start is called before the first frame update
    void Start()
    {
        Canspawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Canspawn)
        {
            InvokeRepeating("Spawn",1,0);
            Canspawn = false;
        }
    }

    void Spawn()
    {
        Instantiate(enemyNormal, transform.position, transform.rotation);
        Canspawn = true;
    }
}
