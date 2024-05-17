using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ManagerDescansos : MonoBehaviour
{
    public TMP_Text textoTemporizador;
    public GameObject Manage;
    public GameObject Manage2;
    public GameObject Manage3;
    public SpawnerObjeto Spawn;
    public InGameStats Stats;

    public void EsperarEsconderPantalla()
    {
        StartCoroutine(EsperarSegundos(StaticData.descansosTiempo));
    }
    IEnumerator EsperarSegundos(float tiempoEspera)
    {
        Manage.SetActive(true);

        yield return StartCoroutine(WaitSecs(2));

        Manage.SetActive(false);
        Manage2.SetActive(true);

        yield return StartCoroutine(WaitSecs(tiempoEspera, textoTemporizador));

        Manage2.SetActive(false);
        Manage3.SetActive(true);

        yield return StartCoroutine(WaitSecs(2));

        Manage3.SetActive(false);

        GlobalManager.cantidadTriggers = 0;
        GlobalManager.seriesCantidad = GlobalManager.seriesCantidad + 1;
        GlobalManager.CanGrab = true;
        GameStateManager.ContinuePlayRoutine = true;

        Spawn.PlayBalls();
        Stats.UpdateScreenValues();
        yield return null;
    }

    public void ActualizarTextoTemporizador(float tiempoRestante, TMP_Text TextoACambiar)
    {
        TextoACambiar.text = tiempoRestante.ToString("0");
    }

    IEnumerator WaitSecs(float SegundosEspera)
    {
        float tiempoRestante = SegundosEspera;
        while (tiempoRestante > 0)
        {
            yield return new WaitForSeconds(1);
            tiempoRestante -= 1;
        }
    }
    IEnumerator WaitSecs(float SegundosEspera, TMP_Text TextoACambiar)
    {
        float tiempoRestante = SegundosEspera;
        while (tiempoRestante > 0)
        {
            ActualizarTextoTemporizador(tiempoRestante, TextoACambiar);
            yield return new WaitForSeconds(1);
            tiempoRestante -= 1;
        }
    }
}
