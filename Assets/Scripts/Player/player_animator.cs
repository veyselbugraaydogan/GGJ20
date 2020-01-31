using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_animator : MonoBehaviour
{
    Animator animator;
    PlayerControl controller;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        controller = GetComponent<PlayerControl>();
        Run();
    }

    
    void Update()
    {

        if (controller.IsAtFinish())
        {
            Celebrate();
        }

    }


    public void Celebrate()
    {
        Dance();
    }


    private void Dance()
    {
        animator.SetBool("Running", false);
        animator.SetBool("Dance", true);
    }


    private void Run()
    {
        animator.SetBool("Running", true);
        animator.SetBool("Dance", false);
    }

}
