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
        StartCoroutine(TestCoroutine(10));
        
        //testCoroutine = TestCoroutine();
        //코루틴 호출방법1
        //StartCoroutine(testCoroutine);
        //코루틴 호출방법2
        //-인자를 넣지 못하는 방법
        //StartCoroutine("TestCoroutine");
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
}
