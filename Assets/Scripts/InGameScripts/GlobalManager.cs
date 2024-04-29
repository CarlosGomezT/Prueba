using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalManager : MonoBehaviour
{
    public static bool cambioDisponible;
    public delegate void TriggerEvent();
    public static event TriggerEvent Interaction;

    public static int cantidadTriggers;
    void Start ()
    {
        Interaction += incrementar;
        cantidadTriggers = 0;
        cambioDisponible = false;
    }
    void Update()
    {
    }

    IEnumerator HabilitarCambio()
    {
        Debug.Log("Se habilito el cambio");
        cambioDisponible = true;
        yield return new WaitForSeconds(10);
        BackToNormal();
    }

    public static void BackToNormal()
    {
        if(!cambioDisponible)
        { 
            return;
        }
        cambioDisponible=false;

        Debug.Log("Se devolvio el estado a falso");
    }

    public void PresionarBoton()
    {
        StopAllCoroutines();
        StartCoroutine(HabilitarCambio());
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
