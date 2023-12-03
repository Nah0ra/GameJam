using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private Transform Goal;
    private NavMeshAgent agent;
    private Transform Player;

    public int EnemyHealth;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Player = GameObject.Find("Player").transform;
        Goal = GameObject.FindWithTag("Goal").transform;
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
        }
        else
        {
            agent.destination = Player.position;
        }
        
    }
}
