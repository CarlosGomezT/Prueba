using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatsWinScreen : MonoBehaviour
{
    public UITimer timer;
    public TMP_Text Tiempo;
    public TMP_Text Stats;

    private void Start()
    {
        float timeElapsed = timer.timeElapsed;
        int minutes = Mathf.FloorToInt(timeElapsed / 60);
        int seconds = Mathf.FloorToInt(timeElapsed % 60);
        Tiempo.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        Stats.text = StaticData.seriesNivel + " series de " + StaticData.repeticionesNivel + " repeticiónes cada una. \n Por un total de " + (StaticData.repeticionesNivel *StaticData.seriesNivel) + " repeticiónes.";
    }
}
