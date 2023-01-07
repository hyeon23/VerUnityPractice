using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //�浹�� gameObject = collision.gameObject
        Debug.Log("�浹 ����");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("�浹 ��");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("�浹 ��");
    }
    private void OnTriggerEnter(Collider other)
    {
        //������ gameObject = other.gameObject
        //������ gameObject�� Component = other.gameObject.GetComponent<~>();
        Debug.Log("���� ����");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("���� ��");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("���� ��");
    }
}
