using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimeSpeedController : MonoBehaviour
{
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }


    private void Update()
    {
        if(Input.GetAxis("Vertical") > 0f)
        {
            animator.SetBool("isMove", true);
        }
        else
        {
            animator.SetBool("isMove", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("doAttack");
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //방식1: 단점 = 모든 애니메이션 속도가 동시 조정
            //animator.speed += 0.2f;
            
            //방식2
            animator.SetFloat("AttackSpeed", animator.GetFloat("AttackSpeed") + 0.2f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //방식1: 단점 = 모든 애니메이션 속도가 동시 조정
            //animator.speed -= 0.2f;

            //방식2
            animator.SetFloat("AttackSpeed", animator.GetFloat("AttackSpeed") - 0.2f);
        }
    }
}
