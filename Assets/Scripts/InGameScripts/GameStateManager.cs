
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    public GameObject UIPause;
    public GameObject UIWin;
    public GameObject Scene;
    public static bool ContinuePlayRoutine = true;
    public string levelToLoad = "MenuScreen";

    private void Start()
    {
        ContinuePlayRoutine = true;
    }
    public void TogglePause()
    {
        Stats.TogglePauseState();
        UIPause.SetActive(!UIPause.activeSelf);
        if (UIPause.activeSelf)
        {
            PauseAudioInMenu(true);
            FreezeTime();
        }
        else
        {
            UnFreezeTime();
            PauseAudioInMenu(false);
        }
    }
    public void ToggleWin()
    {
        Stats.TogglePauseState();
        UIWin.SetActive(!UIWin.activeSelf);
        if (UIWin.activeSelf)
        {
            PauseAudioInMenu(true);
            FreezeTime();
        }
    }
    public void Retry()
    {
        UnFreezeTime();
        StopAllCoroutines();
        GameObject[] allObjects = FindObjectsOfType<GameObject>();
        foreach (GameObject obj in allObjects)
        {
            if (obj != this.gameObject)
            {
                Destroy(obj);
            }
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Menu()
    {
        UnFreezeTime();
        SceneManager.LoadScene(levelToLoad);
    }
    public void PauseAudioInMenu(bool pause)
    {
        AudioSource[] audios = FindObjectsOfType<AudioSource>();

        if (pause == true)
        {
            foreach (AudioSource audio in audios)
            {
                audio.Pause();            
            }
        }
        else
        {
            foreach (AudioSource audio in audios)
            {
                audio.UnPause();
            }
        }
    }
    public void UnFreezeTime()
    {
            Time.timeScale = 1f;
    }
    public void FreezeTime()
    {
            Time.timeScale = 0f;
    }

    public void WaitSeconds(GameObject Canva)
    { 
    }

    IEnumerator EsperarSegundos(int Segs)
    {
        yield return new WaitForSeconds(Segs);
    }
}