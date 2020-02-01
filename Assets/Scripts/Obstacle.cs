using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject brokenRoad;
    public GameObject road;
    public BoxCollider boxCollider;
    public bool isPressed = false;
    public bool isFinished = false;
    [Range(0, 5)]public float timeLeft = 2f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform == brokenRoad.transform)
                {
                    isPressed = true;
                    RepairRoad();
                }
            }
        }

        if(isPressed)
            ReduceTimer();
    }

    private void ReduceTimer()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            isFinished = true;
        }
    }

    private void RepairRoad()
    {
        brokenRoad.SetActive(false);
        road.SetActive(true);
        //boxCollider.SetActive(true);
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(isFinished && other.tag == "Player")
        {
            print("helal bro");
            isPressed = false;
        }
        else if(!isFinished && other.tag == "Player")
        {
            print("öldün gral");
            isPressed = false;
        }
    }
}
