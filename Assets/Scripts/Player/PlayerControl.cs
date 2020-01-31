using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerControl : MonoBehaviour
{
    NavMeshAgent player;
    [SerializeField]Transform target;

    void Start()
    {
        player = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        player.SetDestination(target.position);
    }
}
