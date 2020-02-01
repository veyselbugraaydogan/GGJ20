using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public Transform[] path;

    private int activeWayPoint = 0;

    private void OnDrawGizmos()
    {
        GetPoints();
        //draw gizmos
        Gizmos.color = Color.green;
        for (int i = 0; i < transform.childCount - 1; i++)
        {   

            Gizmos.DrawWireSphere(path[i].position, 0.5f);
            int nextIndex = (i + 1);
            Gizmos.DrawLine(path[i].position, path[nextIndex].position);
            Gizmos.color = Color.white;

        }
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(path[transform.childCount - 1].position, 0.5f);
    }

    private void GetPoints()
    {
        path = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {   
            
            path[i] = transform.GetChild(i);
            //Debug.Log(path[i].position);
        }
    }

    public void Start()
    {
        GetPoints();
    }

    public Vector3 GetActiveWaypoint()
    {
        //Debug.Log("Active waypoint is " + path[activeWayPoint].position);
        return path[activeWayPoint].position;
    }

    public void SetActiveWaypointNext()
    {
        if(activeWayPoint == transform.childCount - 1)
            return;
        activeWayPoint = (activeWayPoint + 1);
    }

    public bool IsAtLastWaypoint()
    {
        return activeWayPoint == transform.childCount - 1;
    }

    public void Reset()
    {
        activeWayPoint = 0;
    }
}