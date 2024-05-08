using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class UILockMenus : MonoBehaviour
{
    public Button[] ToLock;
    public GameObject PastTitle;

    private void Start()
    {
        
    }
    public void LockOtherButttons()
    {
        foreach (Button ToLockButtons in ToLock)
        {
            ToLockButtons.interactable = false;
            ToLockButtons.enabled = false;
        }
        PastTitle.SetActive(false);
    }
    public void UnlockOtherButttons()
    {
        foreach (Button ToUnlockButtons in ToLock)
        {
            ToUnlockButtons.enabled = true;
            ToUnlockButtons.interactable = true;
        }
        PastTitle.SetActive(true);
    }
}
