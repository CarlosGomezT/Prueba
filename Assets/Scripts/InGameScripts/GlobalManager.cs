using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalManager : MonoBehaviour
{
    public delegate void TriggerEvent();
    public static event TriggerEvent Interaction;
    public static int cantidadTriggers;
    public static int seriesCantidad;
    public static bool Ocupado;
    public static bool CanGrab;
    public LoadControlOrder CargarControles;

    void Start ()
    {
        Interaction = delegate { };
        CargarControles.RecoverControlList();
        Interaction += incrementar;
        cantidadTriggers = 0;
        seriesCantidad = 1;
        Ocupado = false;
        CanGrab = true;
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
        cantidadTriggers= cantidadTriggers+1;
    }
}
