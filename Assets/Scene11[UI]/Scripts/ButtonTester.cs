using UnityEngine;
using UnityEngine.UI;

public class ButtonTester : MonoBehaviour
{
    //��ư ���� ��� ���
    public void OnClickButton1()
    {
        Debug.Log("Button Clicked");
    }

    //��ư ���� ��� ���
    public void OnClickButton2()
    {
        Debug.Log("Button Clicked");
    }

    private void Awake()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(OnClickButton2);
    }
}
  