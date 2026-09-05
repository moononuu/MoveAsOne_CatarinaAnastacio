using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace AIControl
{
    public class AIControl : MonoBehaviour
    {

        GameObject[] goalLocation;
        NavMeshAgent agent;

        // Use this for initialization
        void Start()
        {

            agent = GetComponent<NavMeshAgent>();
            goalLocation = GameObject.FindGameObjectsWithTag("Goal");
            int i = Random.Range(0, goalLocation.Length);
            agent.SetDestination(goalLocation[i].transform.position);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}