using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMenuButSelection : MonoBehaviour
{
    public void GlobalLevelSelected(int LevelSelected)
    {
        StaticData.ejercicioSeleccionado = LevelSelected;
    }
    public void GlobalScenarioSelected(int LevelSelected)
    {
        StaticData.escenarioSeleccionado = LevelSelected;
    }
}
