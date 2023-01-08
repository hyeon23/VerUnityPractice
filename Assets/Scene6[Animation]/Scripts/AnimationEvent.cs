using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvent : MonoBehaviour
{
    private void Attack(Object obj)//int i, string s, Object obj
    {
        

        Debug.Log("Damage");
        //Debug.Log(f);
        //Debug.Log(i);
        //Debug.Log(s);
        Debug.Log(obj);
    }

    private void NextEvent()
    {

    }

    private void Start()
    {
        Attack(new Object());
    }
}
