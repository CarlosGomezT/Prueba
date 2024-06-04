using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextsInScene : MonoBehaviour
{
    public TextMeshProUGUI TextTitle;
    public TextMeshProUGUI TextBox;
    public GameObject Zone1;
    public GameObject Zone2;
    public string[] Titles;
    public string[] lines;
    public int IndexChoice;

    void Start()
    {
        TextBox.text = string.Empty;
        CambiarEstado(0);
        if (SeguirMovimientos.Izquierda == true)
        {
            this.transform.position = Zone1.transform.position;
        }
        else
        {
            this.transform.position = Zone2.transform.position;
        }

    }
    private void Update()
    {

        TextTitle.text = Titles[IndexChoice];
        TextBox.text = lines[IndexChoice];


        if (GlobalManager.CanGrab == true)
        {
            if (GlobalManager.Ocupado == true)
            {
                CambiarEstado(1);
            }
            else
            {
                CambiarEstado(0);
            }
        }
        else
        {
            CambiarEstado(2);
        }


    }

    public void CambiarEstado(int posicionIndex)
    {
        IndexChoice = posicionIndex;
    }
}