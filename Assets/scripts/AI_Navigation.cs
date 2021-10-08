using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_Navigation : MonoBehaviour
{
    public GameObject NavMeshGoal;
    // Start is called before the first frame update
    void Start()
    {
        NavMeshGoal = GameObject.Find("Goal");
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = NavMeshGoal.transform.position;
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Kill_enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
