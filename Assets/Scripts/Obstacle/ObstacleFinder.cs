using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ObstacleFinder : MonoBehaviour
{
    public List<Obstacle> obstacles = new List<Obstacle>();
    public float distance;
    public PlayerControl player;

    private void Start()
    {
        Check();
        player = GetComponent<PlayerControl>();
    }

    private void Update()
    {
        ActiveObstacles();
    }

    public void Check()
    {
        obstacles = FindObjectsOfType<Obstacle>().OfType<Obstacle>().ToList();
    }

    public void ActiveObstacles()
    {
        foreach (var obstacle in obstacles)
        {
            if (Vector3.Distance(obstacle.transform.position, player.transform.position) <= distance)
            {
                obstacle.BrokeRoad();
                obstacles.Remove(obstacle);
            }
        }
    }
}
