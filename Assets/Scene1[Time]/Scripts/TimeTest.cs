using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Application.targetFrameRate = 10;
        //Application.targetFrameRate = 30;
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
        {
            //targetFrameFate�� ũ�⿡ ���� �̵� �ӵ��� �޶��� Time.deltaTime�� ������� ��
            transform.position = transform.position + Vector3.forward * Time.deltaTime;
            
        }
    }
}
