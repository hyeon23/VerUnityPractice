using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMover : MonoBehaviour
{
    private void Update()
    {
        //동기 방식: 작동하는 동안 다른 일을 아무것도 할 수 없는 상태
        //비동기 방식: 작동하는 동안 다른 일을 할 수 있는 상태
        
        //동기 Method1
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    SceneManager.LoadScene("VerPractice#9-2");
        //}

        //동기 Method2: 씬 겹쳐서 띄우기
        //LoadSceneMode.Single: Method1과 동일
        //LoadSceneMode.Additive: Method2
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("VerPractice#9-2", LoadSceneMode.Additive);
        }

        //비동기 Method1
        //비동기 함수는 코루틴과 사용해야 함
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(LoadSceneCoroutine());
        }
    }

    IEnumerator LoadSceneCoroutine()
    {
        yield return SceneManager.LoadSceneAsync("VerPractice#9-2", LoadSceneMode.Additive);
    }
}
