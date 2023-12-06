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

    public GameObject Scrap;

    GameData gameData;

    private void Start()
    {
        gameData = GameObject.Find("Scripts").GetComponent<GameData>();
        agent = GetComponent<NavMeshAgent>();
        Goal = GameObject.FindWithTag("Goal").transform;
        animator = GetComponent<Animator>();
        Player = GameObject.FindWithTag("Player").transform;
    }

    public void TakeDamage()
    {
        EnemyHealth --;
        if (EnemyHealth == 0)
        {
            gameData.Scrap++;
            Destroy(gameObject);
        }
    }

    private void Update() 
    {

       if (gameObject.transform.tag == "Enemy")
        {
            agent.destination = Goal.position;
            agent.transform.LookAt(Player.position);
            animator.SetBool("IsWalking", true);
        }
        else if (gameObject.transform.tag == "Elite")
        {
            Player = GameObject.FindWithTag("Player").transform;
            agent.destination = Player.position;
            agent.transform.LookAt(Player.position);
            animator.SetBool("IsWalking", true);
        }

    
    }

    private void OnTriggerEnter(Collider other) {
        if (other.transform.CompareTag("Player"))
        {
            animator.Play("Slash");
            gameData.PlayerHealth--;
        }
        else if (other.transform.CompareTag("Laser"))
        {
            TakeDamage();
        }
    }
}
