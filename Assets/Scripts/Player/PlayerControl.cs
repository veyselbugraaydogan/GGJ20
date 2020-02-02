using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class PlayerControl : MonoBehaviour
{
    NavMeshAgent playerNavMesh;
    GameObject player;
    public AudioClip falling;

    [SerializeField]Transform target;
    [SerializeField]Path path;

    float waypointTolerance = 1f;

    void Start()
    {
        playerNavMesh = GetComponent<NavMeshAgent>();
        player = GetComponent<GameObject>();
    }


    void Update()
    {
        RunToTarget();   
    }


    private void RunToTarget()
    {
        Vector3 target = path.GetActiveWaypoint();
        float distance = Vector3.Distance(target, transform.position);

        if (waypointTolerance > distance)
            path.SetActiveWaypointNext();

        Vector3 targetEyeLevel = new Vector3(target.x, transform.position.y, target.z);
        playerNavMesh.SetDestination(target);

       /* if (waypointTolerance < distance)
            playerNavMesh.transform.LookAt(targetEyeLevel);*/
    }


    public Path GetPath()
    {
        return path;
    }



    public bool IsAtFinish()
    {   
        //Controls if runner is at finish position

        Vector3 target = path.GetActiveWaypoint();
        float distance = Vector3.Distance(target, transform.position);

        if (waypointTolerance > distance && path.IsAtLastWaypoint())
        {
            return true;
        }
            
        return false;
    }

    public void NavMeshStop()
    {
        playerNavMesh.isStopped = true;
    }

    public void NavMeshStart()
    {
        playerNavMesh.isStopped = false;
    }

    

}
