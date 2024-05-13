using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class UIValidatePersonalizacion : MonoBehaviour
{
    public Sprite[] EscenariosToDisplay;
    public Image EscenarioDisplay;
    public UIMasMenos[] BotonesMasMenos;
    private void Start()
    {
        StartValuesClear();
    }
    public void StartValuesClear()
    {
        ChooseScenario();
        BotonesMasMenos[0].value = 3;
        BotonesMasMenos[1].value = 15;
        BotonesMasMenos[2].value = 15;
    }

    public void ChooseScenario()
    {
        EscenarioDisplay.sprite = EscenariosToDisplay[StaticData.escenarioSeleccionado];
    }
    public void LoadScene()
    {
        StaticData.seriesNivel = BotonesMasMenos[0].value;
        StaticData.repeticionesNivel = BotonesMasMenos[1].value;
        StaticData.descansosTiempo = BotonesMasMenos[2].value;


        switch (StaticData.ejercicioSeleccionado)
        {
            case 1:
                SceneManager.LoadScene("Scene1");
                print();

                break;

            case 2:
                SceneManager.LoadScene("Scene1");
                print();
                break;

            case 3:
                SceneManager.LoadScene("Scene1");
                print();
                break;
            case 4:
                SceneManager.LoadScene("Scene1");
                print();
                break;

            default:
                print();
                break;
        }

    }

    public void print()
    {
        Debug.Log("Ejercicio " +StaticData.ejercicioSeleccionado + ", Escenario " + StaticData.escenarioSeleccionado + ", Series " + StaticData.seriesNivel + ", Repeticiones " + StaticData.repeticionesNivel + ", Descanso " + StaticData.descansosTiempo);
    }
}
