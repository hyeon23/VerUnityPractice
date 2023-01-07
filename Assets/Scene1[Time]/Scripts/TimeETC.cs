using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TimeETC : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI timeText;

    // Update is called once per frame
    void Update()
    {
        timeText.text = string.Format("Time = {0}\n RealTimeSinceStartUp = {1}\n TimeSinceLevelLoad = {2}", Time.time, Time.realtimeSinceStartup, Time.timeSinceLevelLoad);
     
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Time.timeScale = Mathf.Clamp(Time.timeScale + Time.unscaledDeltaTime, 0f, 2f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Time.timeScale = Mathf.Clamp(Time.timeScale - Time.unscaledDeltaTime, 0f, 2f);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
        }
    }
}
