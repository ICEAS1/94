using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyContr : MonoBehaviour
{
    // Start is called before the first frame update
    NavMeshAgent agent;
    //public GameObject player;
    //Transform playerTr;

    public Transform[] waypoints;
    int waypointIndex;
    Vector3 target;

    void Start()
    {
        agent=GetComponent<NavMeshAgent>();
        //playerTr=player.GetComponent<Transform>();
        UpdateDestination();
    }

    // Update is called once per frame
    void Update()
    {
        //agent.SetDestination(playerTr.position);
        if(Vector3.Distance(transform.position,target)<1){
            IterateWaypointIndex();
            UpdateDestination();
        }
    }
    void UpdateDestination(){
        target=waypoints[waypointIndex].position;
        agent.SetDestination(target);
    }
    void IterateWaypointIndex(){
        waypointIndex++;
        if(waypointIndex==waypoints.Length){
            waypointIndex=0;
        }
    }
}
