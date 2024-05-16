using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionesVControlador : MonoBehaviour
{
    private Animator velocidadAnimacion;

    private float interCambio = 4.0f;

    public float vMinima = 0.5f;
    public float vMedia = 1.0f;
    public float vMaxima = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        velocidadAnimacion = GetComponent<Animator>();
    }

    //private void CambioDeVelocidad()
    //{
    //    int numAleatorio = Random.Range(0, 3);
    //
    //    switch (numAleatorio)
    //    {
    //        case 0:
    //            velocidadAnimacion.speed = vMinima;
    //            Debug.Log("minima");
    //            break;
    //        case 1:
    //            velocidadAnimacion.speed = vMedia;
    //            Debug.Log("media");
    //            break;
    //        case 2:
    //            velocidadAnimacion.speed = vMaxima;
    //            Debug.Log("maxima");
    //            break;
    //        default: break;
    //    }
    //}
}