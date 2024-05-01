using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

//Ok dude


public class JoyConList : MonoBehaviour
{
    public JoyconManager j;
    public GameObject[] JCList;

    private void Start()
    {
        Debug.Log("Controles " + j.j.Count);
    }
    public void AcomodarControllers(int posicion, int controlPresionado)
    {
        GameObject temp = JCList[posicion];
        JCList[posicion] = JCList[controlPresionado];
        JCList[controlPresionado] = temp;

        JoyconDemo JoyconPresionado = JCList[controlPresionado].GetComponent<JoyconDemo>();
        JoyconDemo JoyConCambiado = JCList[posicion].GetComponent<JoyconDemo>();
        JoyconPresionado.SetControl(posicion);
        JoyConCambiado.SetControl(controlPresionado);

        Debug.Log("Control " + (posicion) + " acomodado");

      //  int cantidadJC=0;
      //
      //  for (int i = 0; i < JCList.Length; i++)
      //  {
      //      // Obtener el GameObject en la posición 'i' de la lista
      //      GameObject gameObjectActual = JCList[i];
      //      Debug.Log("Paso " + (i + 1));
      //
      //      // Verificar si el GameObject actual no es nulo
      //      if (gameObjectActual != null)
      //      {
      //          // Mostrar el nombre del GameObject y su posición en la lista
      //          Debug.Log("El GameObject '" + gameObjectActual.name + "' está en la posición " + i + " de la lista.");
      //          cantidadJC = i;
      //      }
      //  }
     //   for (int j = 0; j <= cantidadJC; j++)
     //   {
     //       GameObject posicion = JCList[j];
     //
     //       JoyconDemo joyconDemo = JCList[j].GetComponent<JoyconDemo>();
     //       
     //       joyconDemo.SetControl(1);
     //       Debug.Log("Control " + (j+1) + " acomodado");
     //   }

    }
}
