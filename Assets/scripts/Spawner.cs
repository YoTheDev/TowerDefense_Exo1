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
        Canspawn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Canspawn)
        {
            Instantiate(enemyNormal, transform.position, transform.rotation);
            Canspawn = false;
        }
    }
}
