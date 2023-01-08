using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    //서로 다른 IEnumerator TestCoroutine()을 반환받아 종료가 불가능
    //-따라서 IEnumerator형 변수를 사용해야 함

    IEnumerator testCoroutine;

    private void Start()
    {

        //코루틴 호출방법1
        //testCoroutine = TestCoroutine();
        //StartCoroutine(testCoroutine);
        //코루틴 호출방법2
        //-인자를 넣지 못하는 방법
        //StartCoroutine("TestCoroutine");

        //코루틴 호출 방법1[인자]
        //StartCoroutine(TestCoroutine(10, 1));

        //코루틴 호출 방법2[인자]
        //-오브젝트 타입을 인자로 받음
        //-오브젝트 타입은 C#에서 모든 타입의 변수 타입의 최상위 타입 => 자동 변환 수행
        //박싱(boxing): 다른 타입 변수를 오브젝트 타입으로 만드는 과정
        //언박싱(unboxing): 오브젝트 타입 변수를 원래 타입으로 되돌리는 과정
        //약점1: 박싱 언박싱 과정은 미세하지만 오버헤드를 일으키므로 최적화를 위해 최소화
        //약점2: 매개변수가 두 개 이상이면, 이름으로 호출하는 방식 사용 불가
        //StartCoroutine("TestCoroutine", 10);

        //yield return: 코드의 제어권을 Unity에 넘겼다가 특정 시점이 되면 다시 제어권을 받고, 코드를 진행
        //yield break: 코드의 제어권을 Unity에 넘기는 시점에 코루틴 종료(반복문의 break처럼 사용)
        StartCoroutine(RetureCoroutine());
        StartCoroutine(BreakCoroutine());
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //코루틴 정지방법1
            //StopCoroutine(testCoroutine);
            //코루틴 정지방법2
            //-[주의]단 같은 이름의 코루틴이 여러개 실행중에 해당 코드를 사용하면, 해당 이름의 모든 코루틴이 정지함
            //-IEnumerator형 변수를 사용한 해당 코루틴은 멈춰지지 않음[=반드시 코루틴 호출방법 2로 호출한 코루틴만 정지]
            //StopCoroutine("TestCoroutine");
            //코루틴 정지방법3
            //-이 컴포넌트가 실행하는 모든 코루틴을 중단시킴
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
