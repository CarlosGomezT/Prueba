using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevelEscenario : MonoBehaviour
{
    public GameObject[] EscenarioToShow;

    void Start()
    {
        try
        {
            EscenarioToShow[StaticData.escenarioSeleccionado].SetActive(true);
        }
        catch
        {
            EscenarioToShow[3].SetActive(true);
        }
    }
}
