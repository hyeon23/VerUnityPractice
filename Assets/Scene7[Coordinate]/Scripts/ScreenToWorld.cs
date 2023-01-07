using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenToWorld : MonoBehaviour
{
    public GameObject prefab;
    private void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Instantiate(prefab, Input.mousePosition, Quaternion.identity);
        //}

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                Instantiate(prefab, hit.point, Quaternion.identity);
            }
            
        }
    }
}
