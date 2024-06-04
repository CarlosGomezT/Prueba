using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameScene : MonoBehaviour
{
    public GameStateManager StateManager;
    public UITimer Timer;
    private void Start()
    {
        Invoke("StartClear", .1f);
    }
    public void StartClear()
    {
        Timer.TiempoReiniciado();
    }
}
