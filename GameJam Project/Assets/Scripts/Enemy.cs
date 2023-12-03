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

    private Transform Player;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Goal = GameObject.FindWithTag("Goal").transform;
        animator = GetComponent<Animator>();
        Player = GameObject.FindWithTag("Player").transform;
        
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

       if (gameObject.transform.tag == "Enemy")
        {
            agent.destination = Goal.position;
            agent.transform.LookAt(Player.position);
        }
        else if (gameObject.transform.tag == "Elite")
        {
            Player = GameObject.FindWithTag("Player").transform;
            agent.destination = Player.position;
            agent.transform.LookAt(Player.position);
        }
    }
}
