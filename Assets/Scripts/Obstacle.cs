using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Vector3 DEFAULT_VECTOR = Vector3.one * -100;

    public float moveSpeed;
    public Transform target;
    public bool isPressed;
    Vector3 direction;

    private void Start() 
    {
        direction = DEFAULT_VECTOR;
    }

    private void Update() 
    {
        if(Input.GetMouseButtonDown(0))
        {
            print("heyy");
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, 100.0f))
            {
                if(hit.transform == this.transform)
                {
                    isPressed = true;
                }
            }
        }

        if(isPressed)
        {
            if(direction == DEFAULT_VECTOR)
                direction = GetDirection();
            Move(); 
        }
    }

    private void Move()
    {
        transform.Translate(direction * moveSpeed * Time.deltaTime);
        if(Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            isPressed = false;
        }
    }

    private Vector3 GetDirection()
    {
        Vector3 pos = target.position;
        Vector3 cardPos = this.transform.position;
        var heading = pos - cardPos;
        var distance = heading.magnitude;
        var direction = heading / distance;
        return direction;         
    }

}
