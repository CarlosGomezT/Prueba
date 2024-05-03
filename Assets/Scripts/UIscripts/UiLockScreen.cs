using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

using UnityEngine.UI;

public class UiLockScreen : MonoBehaviour
{
    public Button[] lockScreen;
    public int[] LockLevel;
    public JoyconManager manager;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("JoyconManager").GetComponent<JoyconManager>();
        LockButtons();
    }
    public void LockButtons()
    {
        for (int i = 0; i < lockScreen.Length; i++)
        {
            if (manager.j.Count >= LockLevel[i])
            {
                lockScreen[i].interactable = true;
                Debug.Log(i);
            }
        }
    }
}
