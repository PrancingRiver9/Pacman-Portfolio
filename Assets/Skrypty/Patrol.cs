using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{


    [SerializeField]
    bool patrolWaiting;

    [SerializeField]
    float totalwaitTime = 3f;

    [SerializeField]
    float switchProbability = 0.2f;

    [SerializeField]
    List<GameObject> patrolPoints;

    NavMeshAgent agent;
    int currentPatrol;
    bool travelling;
    bool waiting;
    bool patrolForward;
    float waitTimer;

    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();

        if (agent == null)
        {
            Debug.LogError("The nav mesh agent component is not attached to " + gameObject.name);
        }
        else
        {
            if (patrolPoints != null && patrolPoints.Count >= 2)
            {
                currentPatrol = 0;
                SetDestination();

            }
            else
            {
                Debug.Log("Insufficient patrol points");
            }
        }
    }


    public void Update()
    {
        if (travelling && agent.remainingDistance <= 1.0f)
        {
            travelling = false;
            if (patrolWaiting)
            {
                waiting = true;
                waitTimer = 0f;
            }
            else
            {
                ChangePatrolPoint();
                SetDestination();
            }
        }

        if (waiting)

        {
            waitTimer += Time.deltaTime;
            if (waitTimer >= totalwaitTime)
            {
                waiting = false;

                ChangePatrolPoint();
                SetDestination();
            }
        }
    }
    private void SetDestination()
    {
        if (patrolPoints != null)
        {

            Vector3 targetVector = patrolPoints[currentPatrol].transform.position;
            agent.SetDestination(targetVector);
            travelling = true;
        }
    }
    void ChangePatrolPoint()
    {
        currentPatrol = UnityEngine.Random.Range(0, patrolPoints.Count);

    }

}
