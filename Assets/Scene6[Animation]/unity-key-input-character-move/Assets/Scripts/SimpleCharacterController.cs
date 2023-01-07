using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCharacterController : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float moveX = 0f;
        //float moveZ = 0f;

        //if(Input.GetKey(KeyCode.W))
        //{
        //    moveZ += 1f;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    moveZ -= 1f;
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    moveX -= 1f;
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    moveZ += 1f;
        //}

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        // 유니티 엔진 1 단위는 1미터
        Vector3 moveVector = new Vector3(moveX, 0f, moveZ);
        bool isMove = moveVector.magnitude > 0;
        animator.SetBool("isMove", isMove);
        if (isMove)
        {
            animator.transform.forward = moveVector;
        }


        transform.Translate(new Vector3(moveX, 0f, moveZ).normalized * Time.deltaTime * 5f);
    }
}
