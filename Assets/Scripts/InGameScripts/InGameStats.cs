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

    void Start()
    {
        StaticData.repeticionesNivel = 3;
        StaticData.seriesNivel = 2;
        Invoke("StartInteraccion", .1f);
    }

    public void StartInteraccion()
    {
        StaticData.repeticionesNivel = 2;
        StaticData.seriesNivel = 2;

        textoContadorRepeticiones.text = GlobalManager.cantidadTriggers.ToString() + " / " + StaticData.repeticionesNivel;
        textoContadorSeries.text = GlobalManager.seriesCantidad + " / " + StaticData.seriesNivel;
        textoInstruccion.text = "Atrape y guarde " + StaticData.repeticionesNivel + " pelotas en su canasta";
        GlobalManager.Interaction += UpdateTexts; 
    }

    public void UpdateTexts()
    {
        if(StaticData.repeticionesNivel > GlobalManager.cantidadTriggers)
        {
            textoContadorRepeticiones.text = GlobalManager.cantidadTriggers + " / " + StaticData.repeticionesNivel;
        }
        else
        {
            textoContadorRepeticiones.text = GlobalManager.cantidadTriggers + " / " + StaticData.repeticionesNivel;
            GameStateManager.ContinuePlayRoutine = false;
            GlobalManager.CanGrab = false;
        }
    }
}
