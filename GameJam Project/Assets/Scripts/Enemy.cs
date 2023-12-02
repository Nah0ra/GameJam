using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private Transform Goal;
    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Goal = GameObject.FindWithTag("Goal").transform;
    }

    private void Update() 
    {
        agent.destination = Goal.position;
    }
}
