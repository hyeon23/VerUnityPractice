using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�ڷ�ƾ ������
//1. Start �Լ��� ȣ��� ���Ŀ� & ���� ������Ʈ�� Ȱ��ȭ�� ���¿��� ȣ���ؾ� ��
//-Start �Լ��� ȣ��Ǳ� ������ Awake()���� �ڷ�ƾ�� ȣ���ϸ� �ȵ�
//-���� ������Ʈ�� ��Ȱ��ȭ�� ���¿��� ���� ��, �ڷ�ƾ ���� �۵� X
//2. �ڷ�ƾ ������ ���ѷ��� ���۽� ������
//-���ѷ��� �ȿ� yield return�� ���� ���, ������ ǥ�õ��� ������, �ڷ�ƾ�� ���� ��ƾ�� ������� �ѱ��� �ʰ� ������� ������ ����
//-�ݺ��� �ȿ� yield return�� �ݵ�� �־���� ��
public class Attacker : MonoBehaviour
{
    public bool isDelay;
    public float delayTime = 2;

    float timer = 0f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isDelay)
            {
                isDelay = true;
                Debug.Log("Attack");
                StartCoroutine(CountAttackDelay());//�ڷ�ƾ ȣ��1
            }
            else
            {
                Debug.Log("Delay"); 
            }
        }
        //Update ���� ����
        //if (isDelay)
        //{
        //    timer += Time.deltaTime;
        //    if(timer > delayTime)
        //    {
        //        timer = 0f;
        //        isDelay = false;
        //    }
        //}
    }

    float x = 3;
    //�ڷ�ƾ ��� ����
    IEnumerator CountAttackDelay()
    {
        //yield return null;//1frame
        //yield return new WaitForSeconds(x);//x seconds

        //Time.timeScale = 0.5f;//�ð��� �帧�� ����
        //Time.timeScale = 2f;//�ð��� �帧�� �ι�
        //yield return new WaitForSecondsRealtime(x);//x seconds without timescale

        //yield return new WaitForFixedUpdate();//fixed update ���� ���� �� �����
        //yield return new WaitForEndOfFrame();//�� �������� �������� ������ ���� ���� �� ���� �������� ����

        yield return new WaitForSeconds(delayTime);
        isDelay = false;
    }

    IEnumerator InfinityLoop()
    {
        yield return null;
        while (true)
        {
            yield return null;
        }
    }
}
