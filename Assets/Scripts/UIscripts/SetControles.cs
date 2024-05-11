using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetControles : MonoBehaviour
{
    public ControlEscenas[] ConectedControlers;
    public JoyconManager manager;
    public JoyConList managerList;

    private void Start()
    {
        SetControllsInScreen();
    }

    public void SetControllsInScreen()
    {

        foreach (ControlEscenas marcador in ConectedControlers)
        {
            marcador.ControlViewDisconnected();
        }
        for (int i = 0; i < manager.j.Count; i++)
        {
            ConectedControlers[i].ControlViewConnected(managerList.JCList[i].originalPos + 1);
            Debug.Log("Control " +i);
        }
    }
    public void ArrangeScreenControls(int numero1, int numero2)
    {
        managerList.AcomodarControllers(numero1, numero2);
        SetControllsInScreen();
    }
}
