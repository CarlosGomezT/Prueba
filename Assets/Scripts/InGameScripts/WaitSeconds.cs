using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WaitSeconds : MonoBehaviour
{
    public float tiempoEspera; 
    public TMP_Text textoTemporizador;
    public GameObject Manage;
    public GameObject Manage2;

    public void EsperarEsconderPantalla()
    {
        StartCoroutine(EsperarSegundos(tiempoEspera));
    }
    IEnumerator EsperarSegundos(float tiempoEspera)
    {
        float tiempoRestante = tiempoEspera;
        while (tiempoRestante > 0)
        {
            ActualizarTextoTemporizador(tiempoRestante);
            yield return new WaitForSeconds(1); 
            tiempoRestante -= 1;
        }
        Manage.SetActive(false);
        Manage2.SetActive(true);
    }

    public void ActualizarTextoTemporizador(float tiempoRestante)
    {
        textoTemporizador.text = tiempoRestante.ToString("0");
    }
    

}
