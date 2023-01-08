using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFillder : MonoBehaviour
{
    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
    }

    float timer = 0f;

    private void Update()
    {
        timer += Time.deltaTime;
        image.fillAmount = Mathf.Sin(timer) * 0.5f + 0.5f;
    }
}
