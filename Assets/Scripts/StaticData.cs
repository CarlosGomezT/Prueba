using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticData : MonoBehaviour
{
    public static int ejercicioSeleccionado;
    public static int escenarioSeleccionado;
    public static int seriesNivel;
    public static int repeticionesNivel;
    public static int descansosTiempo;

    private void Start()
    {
        ejercicioSeleccionado = 1;
        ejercicioSeleccionado = 1;
        seriesNivel = 3;
        repeticionesNivel = 20;
        descansosTiempo = 15;
    }
}


