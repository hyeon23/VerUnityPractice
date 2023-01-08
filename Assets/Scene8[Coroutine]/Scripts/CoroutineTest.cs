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

        //�ڷ�ƾ ȣ����1
        //testCoroutine = TestCoroutine();
        //StartCoroutine(testCoroutine);
        //�ڷ�ƾ ȣ����2
        //-���ڸ� ���� ���ϴ� ���
        //StartCoroutine("TestCoroutine");

        //�ڷ�ƾ ȣ�� ���1[����]
        //StartCoroutine(TestCoroutine(10, 1));

        //�ڷ�ƾ ȣ�� ���2[����]
        //-������Ʈ Ÿ���� ���ڷ� ����
        //-������Ʈ Ÿ���� C#���� ��� Ÿ���� ���� Ÿ���� �ֻ��� Ÿ�� => �ڵ� ��ȯ ����
        //�ڽ�(boxing): �ٸ� Ÿ�� ������ ������Ʈ Ÿ������ ����� ����
        //��ڽ�(unboxing): ������Ʈ Ÿ�� ������ ���� Ÿ������ �ǵ����� ����
        //����1: �ڽ� ��ڽ� ������ �̼������� ������带 ����Ű�Ƿ� ����ȭ�� ���� �ּ�ȭ
        //����2: �Ű������� �� �� �̻��̸�, �̸����� ȣ���ϴ� ��� ��� �Ұ�
        //StartCoroutine("TestCoroutine", 10);

        //yield return: �ڵ��� ������� Unity�� �Ѱ�ٰ� Ư�� ������ �Ǹ� �ٽ� ������� �ް�, �ڵ带 ����
        //yield break: �ڵ��� ������� Unity�� �ѱ�� ������ �ڷ�ƾ ����(�ݺ����� breakó�� ���)
        StartCoroutine(RetureCoroutine());
        StartCoroutine(BreakCoroutine());
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

    IEnumerator TestCoroutine(int count, float time)
    {
        yield return new WaitForSeconds(time);
        int i = 0;
        while (i < count)
        {
            yield return null;
            Debug.Log("Coroutine" + i);
            i++;
        }
    }

    IEnumerator RetureCoroutine()
    {
        Debug.Log("Return 0");
        yield return null;
        Debug.Log("Return 1");
    }

    IEnumerator BreakCoroutine()
    {
        Debug.Log("Break 0");
        yield break;
        Debug.Log("Break 1");
    }
}
