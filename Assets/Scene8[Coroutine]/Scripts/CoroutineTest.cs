using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    //���� �ٸ� IEnumerator TestCoroutine()�� ��ȯ�޾� ���ᰡ �Ұ���
    //-���� IEnumerator�� ������ ����ؾ� ��

    IEnumerator testCoroutine;

    private void Start()
    {
        StartCoroutine(TestCoroutine(10));
        
        //testCoroutine = TestCoroutine();
        //�ڷ�ƾ ȣ����1
        //StartCoroutine(testCoroutine);
        //�ڷ�ƾ ȣ����2
        //-���ڸ� ���� ���ϴ� ���
        //StartCoroutine("TestCoroutine");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //�ڷ�ƾ �������1
            //StopCoroutine(testCoroutine);
            //�ڷ�ƾ �������2
            //-[����]�� ���� �̸��� �ڷ�ƾ�� ������ �����߿� �ش� �ڵ带 ����ϸ�, �ش� �̸��� ��� �ڷ�ƾ�� ������
            //-IEnumerator�� ������ ����� �ش� �ڷ�ƾ�� �������� ����[=�ݵ�� �ڷ�ƾ ȣ���� 2�� ȣ���� �ڷ�ƾ�� ����]
            //StopCoroutine("TestCoroutine");
            //�ڷ�ƾ �������3
            //-�� ������Ʈ�� �����ϴ� ��� �ڷ�ƾ�� �ߴܽ�Ŵ
            StopAllCoroutines();
        }
    }

    IEnumerator TestCoroutine()
    {
        int i = 0;
        while (true)
        {
            yield return null;
            Debug.Log("Coroutine" + i);
            i++;
        }
    }

    IEnumerator TestCoroutine(int count)
    {
        int i = 0;
        while (i < count)
        {
            yield return null;
            Debug.Log("Coroutine" + i);
            i++;
        }
    }
}
