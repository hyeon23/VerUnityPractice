using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonDestroyObject : MonoBehaviour
{
    private void Awake()
    {
        var objs = FindObjectsOfType<DonDestroyObject>();
        if(objs.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
