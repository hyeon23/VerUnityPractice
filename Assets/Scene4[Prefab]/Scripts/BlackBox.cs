using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static BlackBox CreateNewBlackBox()
    {
        //var newBox = GameObject.CreatePrimitive(PrimitiveType.Cube).AddComponent<BlackBox>();
        //newBox.name = "Elegance Black Box";
        //newBox.GetComponent<Renderer>().material = Resources.Load<Material>("M_Black");

        //Instantiate Method1
        var newBox = Instantiate(Resources.Load<BlackBox>("Elegance Black Box"));
        return newBox;

        //Instantiate Method2
    }
}
