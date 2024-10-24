using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.AI;

public class OvejaScript : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float distanceToChase;
    public float timeToJump;
    public float jumpStrenght;

    private NavMeshAgent agent;
    private int currentPointIndex;
    private GameObject player;
    

    void Start()
    {
        player = GameManager.instance.player;
        agent = GetComponent<NavMeshAgent>();
        currentPointIndex = 0;
        if (patrolPoints.Length > 0)
        {
            agent.SetDestination(patrolPoints[currentPointIndex].position);
        } 
    }

    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < distanceToChase)
        {
            ChasePlayer();
        }
        else
        {
            PatrolArea();
        }
    }

    void GoToNextPoint()
    {
        // If there are no patrol points, return
        if (patrolPoints.Length == 0) return;

        // Move to the next point, looping back to the first when needed
        currentPointIndex = (currentPointIndex + 1) % patrolPoints.Length;
        agent.SetDestination(patrolPoints[currentPointIndex].position);
    }

    public void PatrolArea()
    {
        if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
        {
            GoToNextPoint();
        }
    }

    public void ChasePlayer()
    {
        agent.SetDestination(player.transform.position);
    }
}


