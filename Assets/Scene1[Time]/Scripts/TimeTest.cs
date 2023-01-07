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
            //targetFrameFate의 크기에 따라 이동 속도가 달라져 Time.deltaTime을 곱해줘야 함
            transform.position = transform.position + Vector3.forward * Time.deltaTime;
            
        }
    }
}
