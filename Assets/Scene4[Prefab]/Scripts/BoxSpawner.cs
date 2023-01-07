using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {
        Instantiate(prefab);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BlackBox.CreateNewBlackBox();
        }
    }
}
