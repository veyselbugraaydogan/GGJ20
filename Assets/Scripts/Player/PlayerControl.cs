using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class PlayerControl : MonoBehaviour
{
    NavMeshAgent playerNavMesh;
    GameObject player;

    [SerializeField]Transform target;
    [SerializeField]Path path;

    [SerializeField] float waypointTolerance = 0.5f;

    void Start()
    {
        playerNavMesh = GetComponent<NavMeshAgent>();
        player = GetComponent<GameObject>();
    }


    void Update()
    {
       
        Vector3 target = path.GetActiveWaypoint();
        float distance = Vector3.Distance(target, transform.position);
        if (waypointTolerance < distance)
            path.SetActiveWaypointNext();
        playerNavMesh.SetDestination(target);
        //playerNavMesh.transform.LookAt(target);

        
    }


}
