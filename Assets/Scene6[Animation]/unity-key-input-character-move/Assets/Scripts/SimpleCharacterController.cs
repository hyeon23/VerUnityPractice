using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCharacterController : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    Camera characterCamera;

    public GameObject bulletPrefab;

    void Fire()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 firePos = transform.position + animator.transform.forward + new Vector3(0f, 0.5f, 0f);
            var bullet = Instantiate(bulletPrefab, firePos, Quaternion.identity).GetComponent<Bullet>();
            bullet.Fire(animator.transform.forward);
        }
    }
    private void Awake()
    {
        characterCamera = GetComponentInChildren<Camera>();
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
        //transform.Translate(new Vector3(moveX, 0f, moveZ).normalized * Time.deltaTime * 5f);

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        // 유니티 엔진 1 단위는 1미터
        Vector3 moveVector = new Vector3(moveX, 0f, moveZ);
        bool isMove = moveVector.magnitude > 0;
        animator.SetBool("isMove", isMove);
        //if (isMove)
        //{
        //    animator.transform.forward = moveVector;
        //}
        LookMouseCursor();
        Fire();
        Zoom();
        transform.Translate(new Vector3(moveX, 0f, moveZ).normalized * Time.deltaTime * 5f);
    }

    public void LookMouseCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            Vector3 mouseDir = new Vector3(hit.point.x, transform.position.y, hit.point.z) - transform.position;
            animator.transform.forward = mouseDir;
        }
        
    }

    public void Zoom()
    {
        var scroll = Input.mouseScrollDelta;
        characterCamera.fieldOfView = Mathf.Clamp(characterCamera.fieldOfView - scroll.y, 30f, 70f);
    }
}
