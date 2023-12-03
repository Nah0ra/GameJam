using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private Transform Goal;
    private NavMeshAgent agent;

    private Animator animator;

    public int EnemyHealth;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Goal = GameObject.FindWithTag("Goal").transform;
        animator = GetComponent<Animator>();
    }

    public void TakeDamage()
    {
        EnemyHealth--;
        if (EnemyHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    private void Update() 
    {
        agent.destination = Goal.position;
    }
}
