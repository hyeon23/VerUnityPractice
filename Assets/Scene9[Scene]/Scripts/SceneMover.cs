using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMover : MonoBehaviour
{
    private void Update()
    {
        //���� ���: �۵��ϴ� ���� �ٸ� ���� �ƹ��͵� �� �� ���� ����
        //�񵿱� ���: �۵��ϴ� ���� �ٸ� ���� �� �� �ִ� ����
        
        //���� Method1
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    SceneManager.LoadScene("VerPractice#9-2");
        //}

        //���� Method2: �� ���ļ� ����
        //LoadSceneMode.Single: Method1�� ����
        //LoadSceneMode.Additive: Method2
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("VerPractice#9-2", LoadSceneMode.Additive);
        }

        //�񵿱� Method1
        //�񵿱� �Լ��� �ڷ�ƾ�� ����ؾ� ��
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
