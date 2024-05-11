using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControlEscenas : MonoBehaviour
{
    public Image JoyconColor;
    public Sprite[] JoyConWinColor;
    public Image BackgroundButton;
    public int ButtonIndicator;
    public TMP_Text TextNumber;
    public Button BotonCasilla;

    public Color colorDefault = new Color(.18f, .63f, .83f, .14f);


    public void ControlViewConnected(int ControlNum)
    {
        TextNumber.text = ""+ ControlNum;
        BotonCasilla.interactable = true;
        JoyconColor.sprite = JoyConWinColor[1];
        BackgroundButton.color = colorDefault;
    }

    public void ControlViewDisconnected()
    {
        JoyconColor.sprite = JoyConWinColor[0];

        BackgroundButton.color = new Color(0, 0, 0, .6f);

        BotonCasilla.interactable = false;
    }
    
}
