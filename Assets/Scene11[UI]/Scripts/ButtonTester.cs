using UnityEngine;
using UnityEngine.UI;

public class ButtonTester : MonoBehaviour
{
    //버튼 정적 등록 방법
    public void OnClickButton1()
    {
        Debug.Log("Button Clicked");
    }

    //버튼 동적 등록 방법
    public void OnClickButton2()
    {
        Debug.Log("Button Clicked");
    }

    private void Awake()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(OnClickButton2);
    }
}
  