using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraCodigo : MonoBehaviour
{
    public Transform puntoInicial;
    public Transform puntoFinal;
    public float velocidad = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoverC());

    }

    IEnumerator MoverC()
    {
        while (true)
        { 
            float distanciaTotal = Vector3.Distance(puntoInicial.position, puntoFinal.position);
            float distanciaRecorrida = 0.0f;
            float tiempoInicio = Time.time;

            while (distanciaRecorrida < distanciaTotal)
            {
                float tiempoTranscurrido = Time.time - tiempoInicio;
                float distanciaEsteFrame = velocidad * tiempoTranscurrido;
                distanciaRecorrida = Mathf.Min(distanciaEsteFrame, distanciaTotal);

                float t = distanciaRecorrida / distanciaTotal;
                transform.position = Vector3.Lerp(puntoInicial.position, puntoFinal.position, t);

                yield return null;
            }

            //aqui nos aseguramos que el objeto esté en la posición final exacta
            transform.position = puntoFinal.position;

            //mensaje para saber si si llegó al punto final
            Debug.Log("Se ha logrado");

            // esperar un segundo antes de comenzar de nuevo
            yield return new WaitForSeconds(0.5f);
        }
    }
    // Update is called once per frame
    void Update()
    {
      //  float paso = velocidad * Time.deltaTime;
      //  transform.position = Vector3.MoveTowards(transform.position, target.position, paso);
    }
}
