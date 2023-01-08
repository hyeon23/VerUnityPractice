using UnityEngine;
using UnityEngine.UI;

public class UIMover : MonoBehaviour
{
    private RectTransform rectTransform;

    private void Awake()
    {
        //���� ��ũ��Ʈ�� ����� ������Ʈ�� RectTransform
        rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        //UI ��ġ����
        if (Input.GetMouseButton(0))
        {
            rectTransform.anchoredPosition = Input.mousePosition; 
        }

        //UI ũ������
        //-transform.localScale�� ���� �����ϴ� �Ͱ� ������ ���
        //-but IOS �������� ������ �߻���Ű�� �� �ܿ� ���� ������ �߻��� UI���� RectTransform ����ϼ�
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
