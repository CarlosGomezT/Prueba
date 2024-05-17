using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Misc;

public class InGameStats : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textoContadorRepeticiones;
    [SerializeField]
    private TextMeshProUGUI textoContadorSeries;
    [SerializeField]
    private TextMeshProUGUI textoInstruccion;
    [SerializeField]
    private ManagerDescansos managerDescansos;
    [SerializeField]
    private GameStateManager EndGame;


    void Start()
    {
        Invoke("StartInteraccion", .1f);
    }

    public void StartInteraccion()
    {

        UpdateScreenValues();

        textoInstruccion.text = "Atrape y guarde " + StaticData.repeticionesNivel + " pelotas en su canasta";
        GlobalManager.Interaction += UpdateTexts; 
    }

    public void UpdateScreenValues()
    {
        textoContadorRepeticiones.text = GlobalManager.cantidadTriggers.ToString() + " / " + StaticData.repeticionesNivel;
        textoContadorSeries.text = GlobalManager.seriesCantidad + " / " + StaticData.seriesNivel;
    }

    public void UpdateTexts()
    {
        if(StaticData.repeticionesNivel > GlobalManager.cantidadTriggers)
        {
            textoContadorRepeticiones.text = GlobalManager.cantidadTriggers + " / " + StaticData.repeticionesNivel;
        }
        else
        {
            if( GlobalManager.seriesCantidad == StaticData.seriesNivel)
            {
                EndGame.ToggleWin();
                EndGame.Scene.SetActive(false);
            }
            else
            {
                textoContadorRepeticiones.text = GlobalManager.cantidadTriggers + " / " + StaticData.repeticionesNivel;
                GameStateManager.ContinuePlayRoutine = false;
                GlobalManager.CanGrab = false;
                managerDescansos.EsperarEsconderPantalla();
            }
        }
    }
}
