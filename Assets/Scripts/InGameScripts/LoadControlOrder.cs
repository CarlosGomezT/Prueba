using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadControlOrder : MonoBehaviour
{
    public JoyconManager manager;
    public JoyConList ClaseLista;
    public int[] ListaOrig = new int[4];
 
    private void Start()
    {
        if (StaticData.FirstTime == false)
        {
            for (int i = 0; i < 4; i++)
            {
                {
                    StaticData.ListaDeControles[i] = i;
                }
            }
            StaticData.FirstTime = true;
        }
    }
    public void RecoverControlList ()
    {
        ListaOrig = StaticData.ListaDeControles;

        for (int i = 0; i < manager.j.Count; i++)
        {
            ClaseLista.JCList[i].jc_ind = ListaOrig[i];
            Debug.Log("Debug ===== " + ListaOrig[i]);
            ClaseLista.JCList[i].originalPos = ListaOrig[i];
        }
    }
}
