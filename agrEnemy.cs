using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class agrEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    UnityEngine.AI.NavMeshAgent agent;
    public GameObject player;
    float distanceToPlayer;
    float distance=10f;
    Vector3 enemyPosition;
    void Start()
    {
        agent=GetComponent<UnityEngine.AI.NavMeshAgent>();
        enemyPosition=agent.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position,transform.forward*-10f,Color.green);
        Debug.DrawRay(transform.position,transform.forward*10f,Color.green);
        Debug.DrawRay(transform.position,transform.right*-10f,Color.green);
        Debug.DrawRay(transform.position,transform.right*10f,Color.green);

        distanceToPlayer = Vector3.Distance(player.transform.position, agent.transform.position);
        print(distanceToPlayer);

        if(distanceToPlayer<=distance){
            print("ono idet");
            agent.SetDestination(player.transform.position);
        }
        else{
            agent.SetDestination(enemyPosition);
            
        }
    }
}
