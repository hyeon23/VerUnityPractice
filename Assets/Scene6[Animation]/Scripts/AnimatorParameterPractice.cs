using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorParameterPractice : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();

        //animator.SetFloat("New Float", 3.1f);
        //animator.SetInteger("New Int", 1);
        //animator.SetBool("New Int", true);
        //animator.SetTrigger("New Trigger");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetFloat("New Float", 3.1f);
        }
        if (Input.GetKeyUp(KeyCode.F)){
            animator.SetFloat("New Float", 2.9f);
        }
        if (Input.GetKeyDown(KeyCode.I)){
            animator.SetInteger("New Int", 1);
        }
        if (Input.GetKeyUp(KeyCode.I))
        {
            animator.SetInteger("New Int", 0);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            animator.SetBool("New Bool", true);
        }
        if (Input.GetKeyUp(KeyCode.B))
        {
            animator.SetBool("New Bool", false);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            animator.SetTrigger("New Trigger");
        }
    }
}
