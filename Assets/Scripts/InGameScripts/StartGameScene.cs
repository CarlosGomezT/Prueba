using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameScene : MonoBehaviour
{
    public GameStateManager StateManager;
    public JoyConList JoyConList;
    public UITimer Timer;
    private void Start()
    {
        Timer.TiempoReiniciado();
        JoyConList.JCList[0].RecalibrateAllJoycons();
    }


}