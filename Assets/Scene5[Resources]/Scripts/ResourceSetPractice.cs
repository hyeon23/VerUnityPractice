using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceSetPractice : MonoBehaviour
{
    public GameObject prefab;
    public Material material;
    public Texture2D texture2D;
    public TextAsset textAsset;
    
    void Start()
    {
        prefab = Resources.Load<GameObject>("prefab");
        material = Resources.Load<Material>("material");
        texture2D = Resources.Load<Texture2D>("texture");
        textAsset = Resources.Load<TextAsset>("text");
    }

    void Update()
    {
        
    }
}
