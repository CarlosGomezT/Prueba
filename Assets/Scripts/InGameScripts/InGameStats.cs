using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Misc;

public class InGameStats : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textoContador;

    [SerializeField]
    private TextMeshProUGUI textoTiempo;


    void Start()
    {
        textoContador.text = "Contador " +GlobalManager.cantidadTriggers.ToString();
        textoTiempo.text = "Contador 2";
        GlobalManager.Interaction+= UpdateTexts;
        
    }

    public void UpdateTexts()
    {
        textoContador.text = "Contador" + GlobalManager.cantidadTriggers.ToString();
    }
}
