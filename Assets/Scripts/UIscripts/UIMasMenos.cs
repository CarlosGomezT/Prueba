using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIMasMenos : MonoBehaviour
{
    public int value;
    public int valueChange;
    public TMP_Text tiempoContador;

    private void Start()
    {
        UpdateValueText();
    }
    
    public void UpdateValueText()
    {
        tiempoContador.text = "" + value;
    }
    public void Reducir()
    {
        if (value > (valueChange))
        {
            value -= valueChange;
            UpdateValueText();
        }
    }
    public void Incrementar()
    {
        if (value <= (valueChange*4))
        {
            value += valueChange;

            UpdateValueText();
        }
    }
}
