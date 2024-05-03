using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlMarkerUI : MonoBehaviour
{
    public Image[] markers;
    public Color ColorGreen;
    public Color ColorRed;
    public JoyconManager manager;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("JoyconManager").GetComponent<JoyconManager>();
        SetColorScreen();
    }

    public void SetColorScreen ()
    {
        foreach (Image marcador in markers)
        {
            marcador.color = ColorRed;
        }
        for (int i = 0; i<manager.j.Count; i++)
        {
            markers[i].color = ColorGreen;
        }
    }

}
