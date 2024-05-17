using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextsInScene : MonoBehaviour
{
    public TextMeshProUGUI TextTitle;
    public TextMeshProUGUI TextBox;
    public string[] Titles;
    public string[] lines;
    public int IndexChoice;

    void Start()
    {
        TextBox.text = string.Empty;
        CambiarEstado(0);
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