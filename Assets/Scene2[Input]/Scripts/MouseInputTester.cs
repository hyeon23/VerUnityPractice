using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputTester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Down");
        }
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Hold");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Up");
        }
        Debug.Log(Input.mousePosition);

        //Mouse Scrolling Method1
        //한틱 = 0.1
        float value = Input.GetAxis("Mouse ScrollWheel");

        //Mouse Scrolling Method2[우수]
        //한틱 = 1
        Vector2 scrollDelta = Input.mouseScrollDelta;

        if(scrollDelta.y > 0)
        {
            Debug.Log("위로 돌림: " + scrollDelta.y);
        }

        if (scrollDelta.y < 0)
        {
            Debug.Log("아래로 돌림: " + scrollDelta.y);
        }
    }
}
