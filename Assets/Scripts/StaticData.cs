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

    public static int[] ListaDeControles = new int[4];
    public static bool FirstTime = false;

    private void Start()
    {
        ejercicioSeleccionado = 1;
        ejercicioSeleccionado = 1;
        seriesNivel = 3;
        repeticionesNivel = 20;
        descansosTiempo = 15;

        if (FirstTime == false)
        {
            for (int i = 0; i < 4; i++)
            {
                {
                    ListaDeControles[i] = i;
                    Debug.Log("---------------------------");
                }
            }
            FirstTime = true;
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}


