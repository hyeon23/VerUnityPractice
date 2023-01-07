using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //충돌한 gameObject = collision.gameObject
        Debug.Log("충돌 시작");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("충돌 중");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("충돌 끝");
    }
    private void OnTriggerEnter(Collider other)
    {
        //감지한 gameObject = other.gameObject
        //감지한 gameObject의 Component = other.gameObject.GetComponent<~>();
        Debug.Log("감지 시작");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("감지 중");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("감지 끝");
    }
}
