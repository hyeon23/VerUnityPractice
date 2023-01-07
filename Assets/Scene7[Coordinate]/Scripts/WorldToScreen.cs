using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldToScreen : MonoBehaviour
{
    public GameObject WorldObject;
    
    void Update()
    {
        transform.position = Camera.main.WorldToScreenPoint(WorldObject.transform.position);
    }
}
