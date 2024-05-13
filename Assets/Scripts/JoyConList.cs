using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

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
        int tempo = JCList[posicionOrigen].originalPos;
        int temp = JCList[posicionOrigen].jc_ind;
        //JCList[posicionOrigen] = JCList[posicionDestino];
        //JCList[posicionDestino] = temp;


        JCList[posicionOrigen].jc_ind = JCList[posicionDestino].jc_ind;
        JCList[posicionDestino].jc_ind = temp;
        
        JCList[posicionOrigen].originalPos = JCList[posicionDestino].originalPos;
        JCList[posicionDestino].originalPos = tempo;
        


        Debug.Log("Control " + (posicionOrigen) + " acomodado a posicion "+ posicionDestino);
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
