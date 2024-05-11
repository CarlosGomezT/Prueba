using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

//Ok dude


public class JoyConList : MonoBehaviour
{
    public JoyconManager j;
    public JoyconDemo[] JCList;

    private void Start()
    {
        Debug.Log("Controles " + j.j.Count);
    }
    public void AcomodarControllers(int posicionOrigen, int posicionDestino)
    {

        JoyconDemo temp = JCList[posicionOrigen];
        JCList[posicionOrigen] = JCList[posicionDestino];
        JCList[posicionDestino] = temp;

        JCList[posicionOrigen].jc_ind = posicionOrigen;
        JCList[posicionDestino].jc_ind = posicionDestino; 

        Debug.Log("Control " + (posicionOrigen) + " acomodado");

        //GameObject temp = JCList[posicion];
        //JCList[posicion] = JCList[controlPresionado];
        //JCList[controlPresionado] = temp;
        //
        //JoyconDemo JoyconPresionado = JCList[controlPresionado].GetComponent<JoyconDemo>();
        //JoyconDemo JoyConCambiado = JCList[posicion].GetComponent<JoyconDemo>();
        //JoyconPresionado.SetControl(posicion);
        //JoyConCambiado.SetControl(controlPresionado);
        //
        //Debug.Log("Control " + (posicion) + " acomodado");


    }
}
