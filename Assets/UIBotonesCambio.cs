using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBotonesCambio : MonoBehaviour
{
    public Button[] buttonsElement;
    private Button selectedButton;

    private int Boton1;
    private int Boton2;

    public SetControles ControladorDeControles;
    private void Start()
    {
        selectedButton = null;
        foreach (Button button in buttonsElement)
        {
            button.onClick.AddListener(() => ButtonClicked(button));
        }
        StartValuesEmplty();
    }

    void ButtonClicked(Button clickedButton)
    {
        if (selectedButton == null)
        {
            foreach (Button button in buttonsElement)
            {
                button.image.color = Color.cyan;
            }

            selectedButton = clickedButton;
            selectedButton.image.color = Color.yellow;
        }

        else if (selectedButton == clickedButton)
        {
            selectedButton.image.color = Color.cyan;
            StartValuesEmplty();
        }

        else
        {
            selectedButton.image.color = Color.green;
            selectedButton = clickedButton;

            selectedButton.image.color = Color.green;
            Debug.Log("NUMEROS Presionados: " + Boton1 + " y " + Boton2);

            ControladorDeControles.ArrangeScreenControls(Boton1, Boton2);
            
            StartValuesEmplty();
        }
    }
    public void PlaceInArray(int posicion)
    {
        if (selectedButton == null)
        {
            Boton1 = posicion;
            Debug.Log("Seleccionada la posicion "+ posicion);
        }
        else
        {
            Boton2 = posicion;
            Debug.Log("Seleccionada la posicion "+ posicion);
        }

    }

    public void StartValuesEmplty()
    { 
        Boton1 = -1;
        Boton2 = -1;
        selectedButton = null;
        
        foreach (Button button in buttonsElement)
        {
            button.image.color = Color.cyan;
        }
    }

}
