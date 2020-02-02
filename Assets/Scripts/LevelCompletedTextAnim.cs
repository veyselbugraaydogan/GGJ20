using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompletedTextAnim : MonoBehaviour
{
    public string animationName;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        anim.Play(animationName);
    }
}
