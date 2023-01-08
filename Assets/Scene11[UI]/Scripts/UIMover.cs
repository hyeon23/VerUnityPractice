using UnityEngine;
using UnityEngine.UI;

public class UIMover : MonoBehaviour
{
    private RectTransform rectTransform;

    private void Awake()
    {
        //현재 스크립트가 적용된 오브젝트의 RectTransform
        rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        //UI 위치조정
        if (Input.GetMouseButton(0))
        {
            rectTransform.anchoredPosition = Input.mousePosition; 
        }

        //UI 크기조정
        //-transform.localScale을 통해 조작하는 것과 유사한 결과
        //-but IOS 버전에서 문제를 발생시키는 것 외에 여러 문제가 발생해 UI에선 RectTransform 사용하셈
        if (Input.GetKey(KeyCode.Alpha1))
        {
            rectTransform.sizeDelta = rectTransform.sizeDelta * 1.1f;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            rectTransform.sizeDelta = rectTransform.sizeDelta * 0.9f;
        }
    }
}
