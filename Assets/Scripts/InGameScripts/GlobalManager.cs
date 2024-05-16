using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalManager : MonoBehaviour
{
    public delegate void TriggerEvent();
    public static event TriggerEvent Interaction;
    public static int cantidadTriggers;
    public LoadControlOrder CargarControles;

    void Start ()
    {
        CargarControles.RecoverControlList();
        Interaction += incrementar;
        cantidadTriggers = 0;
    }

    public static void StartInteraccion()
    {
        if (Interaction != null)
        {
            Interaction();
        }
    }

    public void incrementar() 
    { 
        cantidadTriggers++;
    }
}
