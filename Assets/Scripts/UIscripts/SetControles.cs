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
            Debug.Log("SetControl view---- " + managerList.JCList[i].originalPos);
        }
    }
    public void ArrangeScreenControls(int numero1, int numero2)
    {
        managerList.AcomodarControllers(numero1, numero2);
        SetControlersForOtherScreens();
        SetControllsInScreen();
    }
    public void VibrateControl(int i)
    {
        managerList.JCList[i].JcVibrate(managerList.JCList[i].originalPos);
    }

    public void SetControlersForOtherScreens()
    {
        System.Array.Clear(StaticData.ListaDeControles, 0, StaticData.ListaDeControles.Length);


        for (int i = 0; i < manager.j.Count; i++)
        {
            StaticData.ListaDeControles[i] = managerList.JCList[i].originalPos;
            Debug.Log("Lista de controles, posicion " + StaticData.ListaDeControles[i]);
        }
    }
}
