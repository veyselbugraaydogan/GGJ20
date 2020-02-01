using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject brokenRoad;
    public GameObject road;
    public bool isPressed = false;
    public bool isFinished = false;

    [SerializeField, Range(0, 5)] float timeLeft = 2f;

    [SerializeField, Range(0, 2)] int tickNumber = 1;
    private int currentTickNumber = 0; 

    public MeshRenderer roadSprite;
    public Material[] materials;

    private void Start() {
        roadSprite.material = materials[currentTickNumber];
    }

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
                    if(currentTickNumber < tickNumber)
                        UpdateRepairSprite();
                    else
                    {
                        isPressed = true;
                        RepairRoad();
                    }
                    
                }
            }
        }

        if(isPressed)
            ReduceTimer();
    }

    private void UpdateRepairSprite()
    {
        currentTickNumber++;
        roadSprite.material = materials[currentTickNumber];
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
