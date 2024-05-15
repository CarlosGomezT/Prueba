using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITimer : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI timerText;
    float timeElapsed;

    private void Start()
    {
        timeElapsed = 0;
    }
    void Update()
    {
        timeElapsed += Time.deltaTime;
        int minutes = Mathf.FloorToInt(timeElapsed / 60);
        int seconds = Mathf.FloorToInt(timeElapsed % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void TiempoReiniciado()
    {
        timeElapsed = 0;
    }

}
