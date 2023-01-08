using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//코루틴 주의점
//1. Start 함수가 호출된 이후에 & 게임 오브젝트가 활성화된 상태에서 호출해야 함
//-Start 함수가 호출되기 이전인 Awake()에서 코루틴을 호출하면 안됨
//-게임 오브젝트가 비활성화된 상태에서 실행 시, 코루틴 정상 작동 X
//2. 코루틴 내에서 무한루프 제작시 주의점
//-무한루프 안에 yield return이 없을 경우, 에러는 표시되지 않지만, 코루틴이 메인 루틴에 제어권을 넘기지 않고 제어권을 독점해 멈춤
//-반복문 안에 yield return을 반드시 넣어줘야 함
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
                StartCoroutine(CountAttackDelay());//코루틴 호출1
            }
            else
            {
                Debug.Log("Delay"); 
            }
        }
        //Update 제작 버전
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
    //코루틴 사용 버전
    IEnumerator CountAttackDelay()
    {
        //yield return null;//1frame
        //yield return new WaitForSeconds(x);//x seconds

        //Time.timeScale = 0.5f;//시간의 흐름이 절반
        //Time.timeScale = 2f;//시간의 흐름이 두배
        //yield return new WaitForSecondsRealtime(x);//x seconds without timescale

        //yield return new WaitForFixedUpdate();//fixed update 과정 끝난 후 제어권
        //yield return new WaitForEndOfFrame();//한 프레임이 지나가는 과정이 전부 끝난 후 가장 마지막에 받음

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
